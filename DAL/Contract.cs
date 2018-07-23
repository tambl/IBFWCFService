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
    
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            this.Contract1 = new HashSet<Contract>();
            this.Policies = new HashSet<Policy>();
        }
    
        public int Id { get; set; }
        public bool IsMemorandum { get; set; }
        public int TypeId { get; set; }
        public int SpecipicationTypeId { get; set; }
        public Nullable<int> PaymentSchemaId { get; set; }
        public Nullable<int> CoverageZoneId { get; set; }
        public string ContractNo { get; set; }
        public string AdditionalContractNo { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> ParentOrganizationId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public bool IsDraft { get; set; }
        public int ContractStatusId { get; set; }
        public int ChannelId { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public Nullable<bool> HasFreeChoiseOfProviders { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHidden { get; set; }
        public int CreateUserId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> ServiceManagerId { get; set; }
        public Nullable<int> ClaimManagerId { get; set; }
        public Nullable<bool> IsNotifyRead { get; set; }
        public Nullable<int> ParentContractLogId { get; set; }
        public Nullable<System.DateTime> FirstPaymentDate { get; set; }
        public Nullable<int> PayCount { get; set; }
        public bool IsSuspend { get; set; }
        public Nullable<int> SuspendReasonTypeId { get; set; }
        public string SuspendReasonComment { get; set; }
        public Nullable<System.DateTime> SuspendReasonDate { get; set; }
        public bool IsAnnulate { get; set; }
        public Nullable<int> AnnulateUserId { get; set; }
        public string AnnulateComment { get; set; }
        public Nullable<System.DateTime> AnnulateDate { get; set; }
        public Nullable<bool> IsUnApproved { get; set; }
        public Nullable<int> OriginalDocumentDeadlineDay { get; set; }
        public Nullable<int> LedManagerId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract1 { get; set; }
        public virtual Contract Contract2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policy> Policies { get; set; }
        public virtual Person Person { get; set; }
        public virtual Person Person1 { get; set; }
    }
}
