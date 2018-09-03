using AutoMapper;
using DAL;
using IBFWCFService.Helpers;
using IBFWCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using System.Text;

namespace IBFWcfServiceApp
{
    // [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class IBFService : IIBFService
    {

        public List<PolicyDto> GetPolicies(string ids, string isConfirmed, string startDate, string endDate, string count, string versionIds, string policyNumber, string clientIds)
        {
            try
            {
                MappingProfile.ConfigureMapper();

                var policies = new List<PolicyDto>();

                var spletIDsConverted = new List<int>();

                if (ids != "null" && !string.IsNullOrEmpty(ids))
                {
                    foreach (var item in ids.Split(','))
                    {
                        spletIDsConverted.Add(Convert.ToInt32(item));
                    }
                }

                var spletVersionIDsConverted = new List<int>();

                if (versionIds != "null" && !string.IsNullOrEmpty(versionIds))
                {
                    foreach (var item in versionIds.Split(','))
                    {
                        spletVersionIDsConverted.Add(Convert.ToInt32(item));
                    }
                }

                var spletClientIDsConverted = new List<int>();

                if (clientIds != "null" && !string.IsNullOrEmpty(clientIds))
                {
                    foreach (var item in clientIds.Split(','))
                    {
                        spletClientIDsConverted.Add(Convert.ToInt32(item));
                    }
                }

                bool tryParseConfirmed;

                bool? isConfirmedConverted = ((isConfirmed != "null" && !string.IsNullOrEmpty(isConfirmed))) && bool.TryParse(isConfirmed, out tryParseConfirmed) == true ? (bool?)Convert.ToBoolean(isConfirmed) : null; //ristvisaa parametrebis dazusteba
                DateTime? startDateConverted = ((startDate != "null" && !string.IsNullOrEmpty(startDate))) ? (DateTime?)Convert.ToDateTime(startDate) : null;
                DateTime? endDateConverted = ((endDate != "null" && !string.IsNullOrEmpty(endDate))) ? (DateTime?)Convert.ToDateTime(endDate) : null;
                int? countConverted = ((count != "null" && !string.IsNullOrEmpty(count))) ? (int?)Convert.ToInt32(count) : null;

                using (var dbContext = new IBFEntities())
                {

                    var policiesTemp = (from p in dbContext.Policies
                                        join pv in dbContext.PolicyVersions on p.Id equals pv.PolicyId
                                        join curr in dbContext.Currencies on p.CurrencyId equals curr.Id
                                        join pvType in dbContext.PolicyVersionStatus on pv.PolicyVersionStatusId equals pvType.Id
                                        join product in dbContext.SubProducts on p.ProductId equals product.Id into producta
                                        from productl in producta.DefaultIfEmpty()

                                        join contract in dbContext.Contracts on p.ContractId equals contract.Id into contracta
                                        from contractl in contracta.DefaultIfEmpty()
                                        join org in dbContext.People on pv.OrganisationId equals org.Id into orga
                                        from orgnl in orga.DefaultIfEmpty()
                                        join client in dbContext.People on pv.ClientId equals client.Id into clienta
                                        from clientl in clienta.DefaultIfEmpty()
                                        join holder in dbContext.People on pv.PolicyHolderId equals holder.Id into holdera
                                        from holderl in holdera.DefaultIfEmpty()
                                        join beneficiary in dbContext.People on pv.BeneficiaryId equals beneficiary.Id into beneficiarya
                                        from beneficiaryl in beneficiarya.DefaultIfEmpty()

                                        where pv.IsHidden == false && pv.IsDelete == false && pv.PolicyStatusId == 3
                                        //&& pv.Id == 4597//3586                                     
                                        && (startDateConverted != null && endDateConverted != null ? pv.StartDate > startDateConverted && pv.StartDate <= endDateConverted :
                                         startDateConverted != null && endDateConverted == null ? pv.StartDate > startDateConverted :
                                         startDateConverted == null && endDateConverted != null ? pv.StartDate <= endDateConverted :
                                         1 == 1)
                                        && (isConfirmedConverted == true ? pv.To1CSynchronizeDate != null : pv.To1CSynchronizeDate == null)
                                        && (spletIDsConverted.Count() > 0 ? spletIDsConverted.Contains(p.Id) && pv.IsActive == true : 1 == 1)
                                        && (spletVersionIDsConverted.Count() > 0 ? spletVersionIDsConverted.Contains(pv.Id) : 1 == 1)
                                        && ((policyNumber != "null" && !string.IsNullOrEmpty(policyNumber)) ? p.PolicyNumber == policyNumber : 1 == 1)
                                        && (spletClientIDsConverted.Count() > 0 ? spletClientIDsConverted.Contains(clientl.Id) : 1 == 1)
                                        select new
                                        {
                                            PolicyId = p.Id,
                                            PolicyNumber = p.PolicyNumber,
                                            PolicyVersionId = pv.Id,
                                            PolicyVersionIsActive = pv.IsActive,
                                            StartDate = pv.StartDate,
                                            EndDate = pv.EndDate,
                                            PolicyCreateDate = p.CreateDate,
                                            PolicyStatusId = pv.PolicyStatusId,
                                            PolicyStatus = pv.PolicyStatu.Name,
                                            PolicyVersionStatusId = pv.PolicyVersionStatusId,
                                            PolicyVersionStatus = pvType.Name,
                                            FinalyPremium = pv.FinalyPremium,
                                            PremiumInGel = pv.PremiumInGel,
                                            CurrencyId = p.CurrencyId,
                                            Currency = curr.Name,
                                            IsMemorandum = contractl.IsMemorandum,
                                            Contract = contractl,
                                            productl,
                                            orgnl,
                                            clientl,
                                            holderl,
                                            beneficiaryl,
                                            reinshuranseShares = pv.PolicyReinsurances.Select(w => new { shares = w.PolicyReinsuranceShares.Where(s => s.IsActive == true && w.IsActive == true && w.ReinsuranceContract.IsActive == true && w.ReinsuranceContract.IsDelete == false && w.ReinsuranceContract.IsHidden == false), w.ReinsuranceContract }),
                                            agentBrokers = pv.PolicyPaymentCoverAgentContracts.Where(w => w.IsActive == true && w.IsDeleted == false && w.ContractAgentContract.IsDelete == false && w.ContractAgentContract.IsHidden == false && w.ContractAgentContract.AgentBroker.IsDelete == false && w.ContractAgentContract.AgentBroker.IsHidden == false).Select(b => b.ContractAgentContract),
                                            commands = pv.PolicyPaymentCoverContractCommands.Where(r => r.IsActive == true && r.IsDeleted == false)
                                        }).Take(countConverted != null && countConverted <= 500 ? (int)countConverted : 500).ToList();

                    //var currencyRatesForSpecificDate = dbContext.CurrencyRates.Where(w => w.RateDate == policiesTemp.FirstOrDefault(f => f.PolicyCreateDate));

                    policies = policiesTemp.Select(s =>

                    new PolicyDto()
                    {
                        PolicyId = s.PolicyId,
                        PolicyVersionId = s.PolicyVersionId,
                        PolicyVersionIsActive = s.PolicyVersionIsActive,
                        Product = Mapper.Map<SubProduct, ProductDto>(s.productl),
                        PolicyNumber = s.PolicyNumber,
                        StartDate = s.StartDate,
                        EndDate = s.EndDate,
                        PolicyStatusId = s.PolicyStatusId,//??? sidan?
                        PolicyStatus = s.PolicyStatus,//??? sidan?
                        PolicyVersionStatusId = s.PolicyVersionStatusId,
                        PolicyVersionStatus = s.PolicyVersionStatus,
                        Insured = Mapper.Map<Person, PersonDto>(s.holderl),
                        Beneficiary = Mapper.Map<Person, PersonDto>(s.beneficiaryl),
                        Client = Mapper.Map<Person, PersonDto>(s.clientl),
                        MemorandumOperator = s.IsMemorandum == true ? Mapper.Map<Person, PersonDto>(s.orgnl) : null,
                        AmountInCurrency = s.FinalyPremium,
                        Amount = s.PremiumInGel,
                        CurrencyId = s.CurrencyId,
                        Currency = s.Currency,
                        Contract = Mapper.Map<Contract, ContractDto>(s.Contract),
                        Reinsuarer = s.reinshuranseShares.Select(k => new ReinsuarerDto
                        {
                            ReinsuarerPerson = Mapper.Map<Person, PersonDto>(k.shares.Select(ss => ss.Person).FirstOrDefault()),
                            Amount = k.shares.Select(ss => ss.Premium).FirstOrDefault(),
                            ReinsuarerContractId = k.ReinsuranceContract.Id,
                            ReinsuarerContractNumber = k.ReinsuranceContract.ContractNumber,
                            ReinsuranceContractEndDate = k.ReinsuranceContract.EndDate,
                            ReinsuranceContractStartDate = k.ReinsuranceContract.StartDate,
                            Currency = k.ReinsuranceContract.CurrencyId
                        }).ToList(),
                        AgentBroker = s.agentBrokers.Select(p => new AgentBrokerDto
                        {
                            AgentBrokerPerson = Mapper.Map<Person, PersonDto>(p.Person),
                            AgentBrokerContractId = p.AgentBrokerContractId,
                            AgentBrokerContractNumber = p.AgentBroker.ContractNo,
                            AgentBrokerContractStartDate = p.AgentBroker.StartDate,
                            AgentBrokerContractEndDate = p.AgentBroker.EndDate,
                            // AgentBrokerCurrency = p.PolicyPaymentCoverAgentContracts.Select(s=>s.Amount * s.PolicyVersion.Policy.Currency.)
                        }).Distinct().ToList()
                    }
                    ).ToList();
                    //ვალუტა, თანხა ვალუტაში, თანხა ეროვნულ ვალუტაში

                    return policies;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool UpdatePolicyVersionSyncDate(string ids)
        {
            var spletIDsConverted = new List<int>();

            if (ids != "null" && !string.IsNullOrEmpty(ids))
            {
                foreach (var item in ids.Split(','))
                {
                    spletIDsConverted.Add(Convert.ToInt32(item));
                }
            }
            else throw new Exception();//return  new HttpResponseMessage(HttpStatusCode.BadRequest);
            try
            {
                using (var dbContext = new IBFEntities())
                {

                    dbContext.PolicyVersions.Where(w => spletIDsConverted.Contains(w.Id)).ToList().ForEach(f => f.To1CSynchronizeDate = DateTime.Now);
                    var rowNum = dbContext.SaveChanges();

                    return rowNum == spletIDsConverted.Count() ? true : false;
                    //new HttpResponseMessage(HttpStatusCode.OK) : new HttpResponseMessage(HttpStatusCode.InternalServerError);
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public List<PersonDto> GetPersons(string ids, string isConfirmed, string startDate, string endDate, string count)
        {
            MappingProfile.ConfigureMapper();

            var spletIDs = ids.Split(',');
            var persons = new List<PersonDto>();
            //var policy = new Policy();

            using (var dbContext = new IBFEntities())
            {
                persons = dbContext.People.Select(Mapper.Map<Person, PersonDto>).Take(10).ToList();
                return persons;
            }
        }
    }
}
