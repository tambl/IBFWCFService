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
    
    public partial class PolicyVersion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PolicyVersion()
        {
            this.PolicyReinsurances = new HashSet<PolicyReinsurance>();
            this.PolicyPaymentCoverAgentContracts = new HashSet<PolicyPaymentCoverAgentContract>();
            this.PolicyPaymentCoverContractCommands = new HashSet<PolicyPaymentCoverContractCommand>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PolicyId { get; set; }
        public Nullable<int> PolicyVersionStatusId { get; set; }
        public Nullable<int> CoverageZoneId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> OrganisationId { get; set; }
        public Nullable<int> BeneficiaryId { get; set; }
        public Nullable<int> PolicyStatusId { get; set; }
        public Nullable<int> PolicyHolderId { get; set; }
        public Nullable<decimal> Risk { get; set; }
        public Nullable<decimal> PremiumInGel { get; set; }
        public Nullable<decimal> LimitInGel { get; set; }
        public Nullable<decimal> NetPremium { get; set; }
        public Nullable<decimal> OriginalPremium { get; set; }
        public Nullable<decimal> FinalyPremium { get; set; }
        public Nullable<int> DiscountPercent { get; set; }
        public System.DateTime EntryDate { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime VersionStartDate { get; set; }
        public System.DateTime VersionEndDate { get; set; }
        public Nullable<int> ReinsuranceStatusId { get; set; }
        public Nullable<bool> IsPrint { get; set; }
        public Nullable<int> PaymentIterationId { get; set; }
        public Nullable<System.DateTime> PrintDate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHidden { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public Nullable<decimal> InitialPremium { get; set; }
        public Nullable<int> ServiceManagerId { get; set; }
        public Nullable<int> SaleManagerId { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> To1CSynchronizeDate { get; set; }
        public Nullable<decimal> MaxCompensationPerPerson { get; set; }
        public string OuterComment { get; set; }
        public Nullable<int> ContractVehicleAssesmentId { get; set; }
    
        public virtual Policy Policy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyReinsurance> PolicyReinsurances { get; set; }
        public virtual Person Person { get; set; }
        public virtual Person Person1 { get; set; }
        public virtual Person Person2 { get; set; }
        public virtual Person Person3 { get; set; }
        public virtual Person Person4 { get; set; }
        public virtual PolicyStatu PolicyStatu { get; set; }
        public virtual PolicyVersionStatu PolicyVersionStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyPaymentCoverAgentContract> PolicyPaymentCoverAgentContracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyPaymentCoverContractCommand> PolicyPaymentCoverContractCommands { get; set; }
    }
}
