using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class PartnerDto
    {
        [DataMember]
        public string insurer { get; set; }  
        [DataMember]
        public string fname { get; set; }
        [DataMember]
        public string lname { get; set; }
        [DataMember]
        public string idn { get; set; }//პირადი ნომერი
        [DataMember]
        public string phone { get; set; }//საკონტაქტო ნომერი
        [DataMember]
        public DateTime? dob { get; set; }        //       "dob": "დაბ.თარიღი DD/MM/YYYY",


        //"insurer": "დამზღვევი",
        //       "fname": "სახელი",
        //       "lname": "გვარი",
        //       "idn": "პირადი",
        //       "dob": "დაბ.თარიღი DD/MM/YYYY",
        //       "phone": "საკონტაქტო ნომერი"
    }

}
