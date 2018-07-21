using IBFWCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace IBFWCFService
{
    public class IBFService : IIBFService
    {

        public List<Person> GetPolicies(string ids, string isConfirmed, string startDate, string endDate, string count)
        {
            var spletIDs = ids.Split(',');
            var persons = new List<Person>();

            var isConfirmedConverted = (bool?)Convert.ToBoolean(isConfirmed) ?? null;
            var startDateConverted = Convert.ToDateTime(startDate);
            var endDateConverted = Convert.ToDateTime(endDate);
            int? countConverted = Convert.ToInt32(count);

            for (int i = 0; i < spletIDs.Count(); i++)
            {
                persons.Add(new Person()
                {
                    PersonId = Convert.ToInt32(spletIDs[i]),
                    FullName = "Policy " + isConfirmedConverted
                });
            }

            return persons;
        }
    }
}
