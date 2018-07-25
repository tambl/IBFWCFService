using IBFWCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL;
using IBFWCFService.Helpers;
using AutoMapper;

namespace IBFWCFService
{
    public class IBFService : IIBFService
    {
        public List<PolicyDto> GetPolicies(string ids, string isConfirmed, string startDate, string endDate, string count)
        {
            try
            {
                MappingProfile.ConfigureMapper();

                var spletIDs = ids.Split(',');
                var policies = new List<PolicyDto>();
                var spletIDsConverted = new List<int>();
                foreach (var item in spletIDs)
                {
                    spletIDsConverted.Add(Convert.ToInt32(item));
                }

                var isConfirmedConverted = (bool?)Convert.ToBoolean(isConfirmed) ?? null; //ristvisaa parametrebis dazusteba
                var startDateConverted = Convert.ToDateTime(startDate);
                var endDateConverted = Convert.ToDateTime(endDate);
                int? countConverted = Convert.ToInt32(count);

                using (var dbContext = new IBFEntities())
                {
                    var policies2 = dbContext.Policies.Include("Contract").Include("Contract.Person").ToList();

                    var policiesTemp = (from p in dbContext.Policies
                                        join pv in dbContext.PolicyVersions on p.Id equals pv.PolicyId
                                        join curr in dbContext.Currencies on p.CurrencyId equals curr.Id
                                        join pvType in dbContext.PolicyVersionStatus on pv.PolicyStatusId equals pvType.Id
                                        join product in dbContext.SubProducts on p.ProductId equals product.Id into producta
                                        from productl in producta.DefaultIfEmpty()
                                        //join c in dbContext.Contracts on p.ContractId equals c.Id
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
                                        where pv.IsActive == true && pv.IsHidden == false && pv.IsDelete == false
                                        //&& !spletIDsConverted.Contains(p.Id)
                                        // && pv.CreateDate > startDateConverted && pv.CreateDate <= endDateConverted
                                        select new { p, pv, productl, contractl, pvType, orgnl, curr, clientl, holderl, beneficiaryl }).Take(10).AsEnumerable();

                    policies = policiesTemp.Select(s =>

                    new PolicyDto()
                    {
                        PolicyId = s.p.Id,
                        PolicyVersionId = s.pv.Id,
                        PolicyVersionIsActive = s.pv.IsActive,
                        Product = Mapper.Map<SubProduct, ProductDto>(s.productl),
                        PolicyNumber = s.p.PolicyNumber,
                        StartDate = (DateTime)s.pv.StartDate,
                        EndDate = (DateTime)s.pv.EndDate,
                        PolicyStatusId = null,//??? sidan?
                        PolicyStatus = null,//??? sidan?
                        PolicyVersionStatusId = s.pv.PolicyStatusId.Value,
                        PolicyVersionStatus = s.pvType.Name,
                        Insured = Mapper.Map<Person, PersonDto>(s.holderl),
                        Beneficiary = Mapper.Map<Person, PersonDto>(s.beneficiaryl),
                        Client = Mapper.Map<Person, PersonDto>(s.clientl),
                        MemorandumOperator = s.contractl.IsMemorandum == true ? Mapper.Map<Person, PersonDto>(s.orgnl) : null,
                        AmountInCurrency = (decimal)s.pv.FinalyPremium,
                        Amount = (decimal)s.pv.PremiumInGel,
                        CurrencyId = s.p.CurrencyId.Value,
                        Currency = s.curr.Name
                        //,Reinsuarer = null,//dasamatebeli
                        //AgentBroker = null//dasamatebeli
                    }
                    ).ToList();

                    return policies;
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

            var isConfirmedConverted = (bool?)Convert.ToBoolean(isConfirmed) ?? null;
            var startDateConverted = Convert.ToDateTime(startDate);
            var endDateConverted = Convert.ToDateTime(endDate);
            int? countConverted = Convert.ToInt32(count);

            using (var dbContext = new IBFEntities())
            {
                persons = dbContext.People.Select(Mapper.Map<Person, PersonDto>).Take(10).ToList();
                return persons;
            }

            //for (int i = 0; i < spletIDs.Count(); i++)
            //{
            //    persons.Add(new PersonDto()
            //    {
            //        PersonId = Convert.ToInt32(spletIDs[i]),
            //        FullName = "Policy " + isConfirmedConverted
            //    });
            //}

            //return persons;
        }
    }
}
