using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IBFWCFService.Models
{
    [DataContract]
    public class PositionReturnDto
    {
        [DataMember]
        public string name { get; set; }
       
        [DataMember]
        public List<PositionDto> positions { get; set; }
    }
}