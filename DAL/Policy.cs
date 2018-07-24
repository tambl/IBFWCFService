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
    
    public partial class Policy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Policy()
        {
            this.Policy1 = new HashSet<Policy>();
            this.PolicyVersions = new HashSet<PolicyVersion>();
        }
    
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public Nullable<int> ContractPackageId { get; set; }
        public Nullable<int> MedicalCoverageId { get; set; }
        public Nullable<int> VehicleAssessmentId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> ServiceManageraId { get; set; }
        public Nullable<int> ClaimManageraId { get; set; }
        public bool IsMain { get; set; }
        public bool IsVerifySupervision { get; set; }
        public Nullable<System.DateTime> VerifySupervisionDate { get; set; }
        public Nullable<int> AnnulatedReasonId { get; set; }
        public Nullable<int> PauseUserId { get; set; }
        public Nullable<System.DateTime> PauseDate { get; set; }
        public string PauseComment { get; set; }
        public string AnnulatedComment { get; set; }
        public Nullable<int> AnnulatedUserId { get; set; }
        public Nullable<bool> IsAnnulated { get; set; }
        public Nullable<int> ParentPolicyId { get; set; }
        public Nullable<int> MainPolicyHolderId { get; set; }
        public Nullable<int> ContractId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> InsurancedStartDate { get; set; }
        public bool IsPaused { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHidden { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public Nullable<bool> IsNotifyRead { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public Nullable<int> ParentPolicyLogId { get; set; }
        public Nullable<int> ContractPackageServiceId { get; set; }
        public Nullable<int> ApprovePersonCount { get; set; }
    
        public virtual Contract Contract { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policy> Policy1 { get; set; }
        public virtual Policy Policy2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyVersion> PolicyVersions { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual SubProduct SubProduct { get; set; }
    }
}
