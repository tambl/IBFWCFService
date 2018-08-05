using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class PolicyDto
    {
        [DataMember]
        public int PolicyId { get; set; }
        [DataMember]
        public int PolicyVersionId { get; set; }
        [DataMember]
        public bool PolicyVersionIsActive { get; set; }
        [DataMember]
        public ProductDto Product { get; set; }
        [DataMember]
        public string PolicyNumber { get; set; }
        [DataMember]
        public DateTime? StartDate { get; set; }
        [DataMember]
        public DateTime? EndDate { get; set; }
        [DataMember]
        public int? PolicyStatusId { get; set; }
        [DataMember]
        public string PolicyStatus { get; set; }
        [DataMember]
        public int? PolicyVersionStatusId { get; set; }
        [DataMember]
        public string PolicyVersionStatus { get; set; }
        [DataMember]
        public PersonDto Insured { get; set; }
        [DataMember]
        public PersonDto Beneficiary { get; set; }
        [DataMember]
        public PersonDto Client { get; set; }
        [DataMember]
        public PersonDto MemorandumOperator { get; set; }
        [DataMember] //მემორანდუმის დროს ხელშეკრულების დამდები და რეალური კლიენტი განსხვავდება ხოლმე{ get; set; } 
       
        public decimal? AmountInCurrency { get; set; }
        [DataMember] //თანხა ვალუტაში
        public decimal? Amount { get; set; }
        [DataMember] // თანხა ეროვნულ ვალუტაში
        public int? CurrencyId { get; set; }
        [DataMember]
        public string Currency { get; set; }
        [DataMember]
        public ContractDto Contract { get; set; }
        [DataMember]
        public List<ReinsuarerDto> Reinsuarer { get; set; }
        [DataMember]
        public List<AgentBrokerDto> AgentBroker { get; set; }

    }

}
