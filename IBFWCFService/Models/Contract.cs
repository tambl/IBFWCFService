using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class Contract
    {
        [DataMember]
        public int ContractId { get; set; }
        [DataMember] //ე.წ. IBF კოდი
        public string ContractName { get; set; }
        [DataMember]
        public string ContractFullName { get; set; }
        [DataMember] 
        public Person Client { get; set; }
        [DataMember]
        public DateTime PeriodStartDate { get; set; }
        [DataMember]
        public DateTime PeriodEndDate { get; set; }
        [DataMember]
        public string ContractInternalNumber { get; set; }
        [DataMember] //კონტრაქტის შიდა ნომერი (ანიჭებს სისტემა)
        public string ContractExternalNumber { get; set; }
        [DataMember] // კონტრაქტის გარე ნომერი. (ივსება ხელით საჭიროების შემთხვევაში)
        public int CurrencyId { get; set; }
        [DataMember]
        public string Currenct { get; set; }
        [DataMember] // ვალუტის აბრევიატურა GEL, USD….
        public bool IsMemorandum { get; set; }

    }
}
