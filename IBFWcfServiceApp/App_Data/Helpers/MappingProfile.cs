using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using IBFWCFService.Models;

namespace IBFWCFService.Helpers
{
    public static class MappingProfile
    {
        public static void ConfigureMapper()
        {
            Mapper.Reset();
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new ModelProfiles());

            });
        }
    }

    public class ModelProfiles : Profile
    {
        public ModelProfiles()
        {
            CreateMap<Policy, PolicyDto>().ForMember(
                dest => dest.PolicyId,
                opt => opt.MapFrom(src => src.Id)).ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.PolicyVersions.Sum(s => s.FinalyPremium)));
            CreateMap<Person, PersonDto>().ForMember(
                dest => dest.PersonId,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(
                dest => dest.FullName,
                opt => opt.MapFrom(src => src.FirstName + " " + src.Lastname))
                .ForMember(
                dest => dest.IdentificationCode,
                opt => opt.MapFrom(src => src.PersonNo ?? src.IdentityNumber))
                .ForMember(
                dest => dest.LegalFormId,
                opt => opt.MapFrom(src => src.LegalStatusId)) //saidan?
                .ForMember(
                dest => dest.LegalFormName,
                opt => opt.MapFrom(src => src.LegalStatu.Name))//saidan
                .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => src.FirstName + " " + src.Lastname))
                .ForMember(
                dest => dest.PersonTypeId,
                opt => opt.MapFrom(src => src.PersonTypeId))
                ;

            CreateMap<Product, ProductCategoryDto>().ForMember(
              dest => dest.ProductCategoryId,
              opt => opt.MapFrom(src => src.Id))
              .ForMember(
              dest => dest.ProductCategoryName,
              opt => opt.MapFrom(src => src.Name))
              .ForMember(
              dest => dest.ProductTypeId,
              opt => opt.MapFrom(src => src.ProductTypeId))
              .ForMember(
              dest => dest.ProductTypeName,
              opt => opt.MapFrom(src => src.ProductType.Name));

            CreateMap<SubProduct, ProductDto>().ForMember(
                dest => dest.ProductId,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ProductCategory, opt => opt.MapFrom(src => src.Product));

            CreateMap<ReinsuranceContract, ReinsuarerDto>().ForMember(
                dest => dest.ReinsuarerContractId,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ReinsuarerContractNumber, opt => opt.MapFrom(src => src.ContractNumber))
                .ForMember(dest => dest.ReinsuranceContractStartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.ReinsuranceContractEndDate, opt => opt.MapFrom(src => src.EndDate))
                ;
            CreateMap<PolicyReinsuranceShare, ReinsuarerDto>().ForMember(
               dest => dest.ReinsuarerPerson,
               opt => opt.MapFrom(src => src.Person))
               .ForMember(
               dest => dest.Amount,
               opt => opt.MapFrom(src => src.Premium))
               ;

            CreateMap<AgentBroker, AgentBrokerDto>().ForMember(
                dest => dest.AgentBrokerPerson,
                opt => opt.MapFrom(src => src.Person))
                ;

            CreateMap<Contract, ContractDto>().ForMember(
                dest => dest.ContractId,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.Person))
                .ForMember(dest => dest.ContractExternalNumber, opt => opt.MapFrom(src => src.AdditionalContractNo))//????
                .ForMember(dest => dest.ContractFullName, opt => opt.MapFrom(src => src.ContractNo))
                .ForMember(dest => dest.ContractInternalNumber, opt => opt.MapFrom(src => src.ContractNo))//????
                .ForMember(dest => dest.ContractName, opt => opt.MapFrom(src => src.AdditionalContractNo))//????
                .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.Currency.Name))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.IsMemorandum, opt => opt.MapFrom(src => src.IsMemorandum))
                .ForMember(dest => dest.ContractPeriodStartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.ContractPeriodEndDate, opt => opt.MapFrom(src => src.EndDate))
                ;

            CreateMap<Transfer, TransferDto>().ForMember(
                dest => dest.Client, opt => opt.MapFrom(src => src.Person))
                .ForMember(dest => dest.TransferId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.Currency.Name))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.Purpose, opt => opt.MapFrom(src => src.Payer))
                .ForMember(dest => dest.IncomeType, opt => opt.MapFrom(src => src.IncomeType.Name))
                .ForMember(dest => dest.IncomeTypeId, opt => opt.MapFrom(src => src.IncomeTypeId));

            CreateMap<Employe, EmployeeDto>().ForMember(
               dest => dest.ID, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.idn, opt => opt.MapFrom(src => src.Person.PersonNo))
            .ForMember(dest => dest.lname, opt => opt.MapFrom(src => src.Person.Lastname))
            .ForMember(dest => dest.fname, opt => opt.MapFrom(src => src.Person.FirstName))
            .ForMember(dest => dest.positionid, opt => opt.ResolveUsing(src =>
            {
                if (src.Person.PersonPositions.Count > 0)
                {
                    return src.Person.PersonPositions.FirstOrDefault().PositionId;
                }
                else return (int?)null;
            }))
            .ForMember(dest => dest.phone, opt => opt.ResolveUsing(src =>
            {
                if (src.Person.PersonContacts.Count > 0)
                {
                    if (src.Person.PersonContacts.Any(a => a.ContactTypeId == 2))
                    {
                        if (src.Person.PersonContacts.Any(a => a.IsDefault))
                        {
                            return src.Person.PersonContacts.FirstOrDefault(a => a.IsDefault && a.ContactTypeId == 2).Contact;
                        }
                        else
                        {
                            return src.Person.PersonContacts.FirstOrDefault(s => s.ContactTypeId == 2).Contact;
                        }
                    }
                    else return "";
                }
                else return "";
            }));


            CreateMap<Position, PositionDto>().ForMember(
              dest => dest.positionid, opt => opt.MapFrom(src => src.Id))
              .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.Name));

            CreateMap<Person, PartnerDto>().ForMember(
              dest => dest.idn, opt => opt.MapFrom(src => src.PersonNo ?? src.IdentityNumber))
              .ForMember(dest => dest.fname, opt => opt.MapFrom(src => src.FirstName))
              .ForMember(dest => dest.lname, opt => opt.MapFrom(src => src.Lastname))
              .ForMember(dest => dest.dob, opt => opt.MapFrom(src => src.BirthDate))
              .ForMember(dest => dest.phone, opt => opt.ResolveUsing(src =>
              {
                  if (src.PersonContacts.Count > 0)
                  {
                      if (src.PersonContacts.Any(a => a.ContactTypeId == 2))
                      {
                          if (src.PersonContacts.Any(a => a.IsDefault))
                          {
                              return src.PersonContacts.FirstOrDefault(a => a.IsDefault && a.ContactTypeId == 2).Contact;
                          }
                          else
                          {
                              return src.PersonContacts.FirstOrDefault(s => s.ContactTypeId == 2).Contact;
                          }
                      }
                      else return "";
                  }
                  else return "";
              }));


            //CreateMap<PolicyVersion, PolicyV2Dto>()
            //  .ForMember(dest => dest.num, opt => opt.MapFrom(src => src.Policy.PolicyNumber))
            //  .ForMember(dest => dest.startdate, opt => opt.MapFrom(src => src.StartDate))
            //  .ForMember(dest => dest.enddate, opt => opt.MapFrom(src => src.EndDate))
            //  .ForMember(dest => dest.note, opt => opt.MapFrom(src => src.InnerComment))
            //  .ForMember(dest => dest.status, opt => opt.MapFrom(src => src.PolicyStatu.Name))
            //  .ForMember(dest => dest.package, opt => opt.ResolveUsing(src =>
            //  {
            //      return src.Policy.ContractPackageService.ContractPackage.Name;
            //  }))
            //  .ForMember(dest => dest.canceldate, opt => opt.ResolveUsing(src =>
            //  {
            //      if (src.PolicyVersionStatusId == 3)
            //      {
            //          return src.StartDate;

            //      }
            //      return null;

            //  }));

            CreateMap<PolicyContractPackageService, ServiceDto>()
             .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
             .ForMember(dest => dest.name, opt => opt.ResolveUsing(res =>
             {
                 if (res.ProductId != null)
                 {
                     if (res.SubProduct.Dictionary != null && res.SubProduct.Dictionary.Translates.Count > 0)
                     {
                         var productname = res.SubProduct.Dictionary.Translates
                             .FirstOrDefault(a => a.LanguageId == 1);
                         if (productname != null)
                         {
                             return productname.TranslatedText;
                         }

                         return res.SubProduct.Name;
                     }

                     return res.SubProduct.Name;
                 }

                 if (res.ContractPackageService.ServiceId != null)
                 {
                     if (res.ContractPackageService.Service.Dictionary != null && res.ContractPackageService.Service.Dictionary.Translates.Count > 0)
                     {

                         var productname = res.ContractPackageService.Service.Dictionary.Translates.FirstOrDefault(a => a.LanguageId == 1);
                         if (productname != null)
                         {
                             return productname.TranslatedText;
                         }
                         return res.ContractPackageService.Service.Name;
                     }
                     return res.ContractPackageService.Service.Name;

                 }

                 return string.Empty;
             }))
             .ForMember(dest => dest.limit, opt => opt.MapFrom(src => src.Limit))
             .ForMember(dest => dest.left, opt => opt.MapFrom(res => res.Limit - res.SpentMoney - res.BlockedAmount))
             .ForMember(dest => dest.share, opt => opt.MapFrom(src => src.PercentLimit))
              .ForMember(dest => dest.parentid, opt => opt.MapFrom(src => src.ContractPackageServiceParentId));


        }
    }
}
