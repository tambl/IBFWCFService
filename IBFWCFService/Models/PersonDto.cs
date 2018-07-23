using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class PersonDto
    {
        [DataMember]
        public int PersonId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public int PersonTypeId { get; set; }
        [DataMember] // 1 ფიზიკური პირი{ get; set; } [DataMember] 2 იურიდიული პირი
        public int? LegalFormId { get; set; }
        [DataMember]
        public string LegalFormName { get; set; }
        [DataMember]
        public string IdentificationCode { get; set; }
    }

}
