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
            CreateMap<Policy, PolicyDto>().ReverseMap();
            CreateMap<Person, PersonDto>().ReverseMap();
        }
    }
}
