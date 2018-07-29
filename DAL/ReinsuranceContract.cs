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
    
    public partial class ReinsuranceContract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReinsuranceContract()
        {
            this.PolicyReinsurances = new HashSet<PolicyReinsurance>();
            this.ReinsuranceContract1 = new HashSet<ReinsuranceContract>();
        }
    
        public int Id { get; set; }
        public bool IsLife { get; set; }
        public bool IsUniversal { get; set; }
        public string ContractNumber { get; set; }
        public int CurrencyId { get; set; }
        public int ReinsuranceTypeId { get; set; }
        public int ReinsuranceSpecificationId { get; set; }
        public Nullable<int> ReinsuranceEventId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int ReinsuranceActionTypeId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public Nullable<System.DateTime> LastModifyDate { get; set; }
        public Nullable<int> LastModifyUserId { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHidden { get; set; }
        public bool IsActive { get; set; }
        public int ProductLineId { get; set; }
        public decimal TreatLimit { get; set; }
        public Nullable<int> ReinsuranceLimitTypeId { get; set; }
        public Nullable<decimal> ReinsuredOrganizationSharePercen { get; set; }
        public Nullable<decimal> ReinsuredOrganizationShareAmount { get; set; }
        public Nullable<decimal> ReinshuarersSharePercent { get; set; }
        public Nullable<decimal> ReinshuarersShareAmount { get; set; }
        public int PayCount { get; set; }
        public int CommissionTypeId { get; set; }
        public Nullable<int> AuthorizationUserId { get; set; }
        public Nullable<System.DateTime> UserAuthorizationDate { get; set; }
        public bool IsAuthorized { get; set; }
        public string TreatyName { get; set; }
        public Nullable<int> CedingCommission { get; set; }
        public Nullable<int> PolicyPeriodLimitation { get; set; }
        public Nullable<double> BrokerMinDeposit { get; set; }
        public Nullable<int> ParentLogId { get; set; }
    
        public virtual Currency Currency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyReinsurance> PolicyReinsurances { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReinsuranceContract> ReinsuranceContract1 { get; set; }
        public virtual ReinsuranceContract ReinsuranceContract2 { get; set; }
    }
}