using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class AgentBroker
    {
        [DataMember]
        public int AgentBrokerContractId { get; set; }
        [DataMember]
        public string AgentBrokerContractNumber { get; set; }
        [DataMember]
        public Person AgentBrokerPerson { get; set; }
        [DataMember]
        public DateTime AgentBrokerContractStartDate { get; set; }
        [DataMember]
        public DateTime AgentBrokerContractEndDate { get; set; }        
    }


}
