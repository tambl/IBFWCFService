using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class PolicyV2Dto
    {
        [DataMember]
        public string package { get; set; }
        [DataMember]
        public string num { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public DateTime? startdate { get; set; }
        [DataMember]
        public DateTime? enddate { get; set; }
        [DataMember]
        public DateTime? canceldate { get; set; }
        [DataMember]
        public string note { get; set; }
    }

}
