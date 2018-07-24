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
using System.Text;

namespace IBFWcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class IBFService : IIBFService
    {
        public List<PersonDto> GetPolicies(string ids, string isConfirmed, string startDate, string endDate, string count)
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
