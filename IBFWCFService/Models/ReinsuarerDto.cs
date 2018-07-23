using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class ReinsuarerDto
    {
        [DataMember]
        public int ReinsuarerContractId { get; set; }
        [DataMember]
        public string ReinsuarerContractNumber { get; set; }
        [DataMember]
        public PersonDto ReinsuarerPerson { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public decimal Currency { get; set; }
        [DataMember]
        public DateTime ReinsuranceContractStartDate { get; set; }
        [DataMember]
        public DateTime ReinsuranceContractEndDate { get; set; }
    }

}
