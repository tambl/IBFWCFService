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
        public static void ConfigureMapper() {           
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new ModelProfiles());
               
            });
        }
    }

    public class ModelProfiles : Profile {
        public ModelProfiles()
        {
            CreateMap<Policy, PolicyDto>().ForMember(
                dest => dest.PolicyId,
                opt => opt.MapFrom(src => src.Id)).ForMember(dest => dest.Amount,opt => opt.MapFrom(src => src.PolicyVersions.Sum(s=>s.FinalyPremium)));
            CreateMap<Person, PersonDto>().ForMember(
                dest => dest.PersonId,
                opt => opt.MapFrom(src => src.Id))
                .ForMember(
                dest => dest.FullName,
                opt => opt.MapFrom(src => src.FirstName + " "+src.Lastname))
                .ForMember(
                dest => dest.IdentificationCode,
                opt => opt.MapFrom(src => src.PersonNo))
                .ForMember(
                dest => dest.LegalFormId,
                opt => opt.MapFrom(src => src.LegalStatusId)) //??
                .ForMember(
                dest => dest.LegalFormName,
                opt => opt.MapFrom(src => src.LegalStatu.Name))//
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
        }
    }
}
