//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class IncomingOrderTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IncomingOrderTable()
        {
            this.Transfers = new HashSet<Transfer>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ClientId { get; set; }
        public string DocNumber { get; set; }
        public string Payer { get; set; }
        public Nullable<int> IncomingChannelld { get; set; }
        public Nullable<int> BankId { get; set; }
        public string Account { get; set; }
        public Nullable<decimal> DebitAmount { get; set; }
        public int CurrencyId { get; set; }
        public string TaxCode { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHidden { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public Nullable<System.DateTime> IncomeDate { get; set; }
        public Nullable<int> IncomeTypeId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> InvoiceId { get; set; }
        public Nullable<bool> IsNotifyRead { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<bool> IsIncomingOrderDistr { get; set; }
        public string Comment { get; set; }
    
        public virtual IncomeType IncomeType { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Person Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer> Transfers { get; set; }
        public virtual User User { get; set; }
    }
}
