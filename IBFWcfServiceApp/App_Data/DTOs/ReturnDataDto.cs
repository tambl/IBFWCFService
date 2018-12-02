using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class RerutnDataDto
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public List<PolicyInfoDto> maindata { get; set; }
    }
}
