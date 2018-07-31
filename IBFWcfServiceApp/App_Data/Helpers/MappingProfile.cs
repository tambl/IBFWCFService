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
                opt => opt.MapFrom(src => src.FirstName))
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
        }
    }
}
