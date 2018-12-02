using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class ServiceDto
    {

        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public decimal limit { get; set; }
        [DataMember]
        public decimal share { get; set; }
        [DataMember]
        public decimal left { get; set; }


        //"id": 67546456,
        //"name": "სერვისის დასახელება",
        //"": "სრული ლიმიტი",
        //"limit": 15000,
        //"":"თანაგადახდა %",
        //"share": 80,
        //"":"დარჩენილი თანხა",
        //"left": 4000
    }

}
