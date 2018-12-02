using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class PolicyInfoDto
    {
        [DataMember]
        public PartnerDto partner { get; set; }
        [DataMember]
        public PolicyV2Dto policy { get; set; }
        [DataMember]
        public List<ServiceDto> services { get; set; }

    }

}
