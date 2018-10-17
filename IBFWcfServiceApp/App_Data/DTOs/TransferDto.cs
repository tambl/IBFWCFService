using System;
using System.Runtime.Serialization;


namespace IBFWCFService.Models
{
    [DataContract]
    public class TransferDto
    {
        [DataMember]
        public int TransferId { get; set; }
        [DataMember]
        public DateTime IncomeDate { get; set; }
        [DataMember]
        public string Account { get; set; }
        [DataMember]
        public int CurrencyId { get; set; }
        [DataMember]
        public string Currency { get; set; }
        [DataMember]
        public decimal IncomeAmount { get; set; }
        [DataMember]
        public decimal IncomeAmountInCurrency { get; set; }
        [DataMember]
        public string Purpose { get; set; }
        [DataMember]
        public int IncomeTypeId { get; set; }
        [DataMember]
        public string IncomeType { get; set; }
        [DataMember]
        public PersonDto Client { get; set; }
    }
}