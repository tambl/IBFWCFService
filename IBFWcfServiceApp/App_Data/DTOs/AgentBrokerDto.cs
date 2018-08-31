using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class AgentBrokerDto
    {
        [DataMember]
        public int AgentBrokerContractId { get; set; }
        [DataMember]
        public string AgentBrokerContractNumber { get; set; }
        [DataMember]
        public PersonDto AgentBrokerPerson { get; set; }
        [DataMember]
        public DateTime AgentBrokerContractStartDate { get; set; }
        [DataMember]
        public DateTime AgentBrokerContractEndDate { get; set; }
        [DataMember]
        public string AgentBrokerCurrency { get; set; }

        [DataMember]
        public decimal AgentBrokerAmount { get; set; }

        [DataMember]
        public decimal AgentBrokerAmountInGel { get; set; }
    }


}
