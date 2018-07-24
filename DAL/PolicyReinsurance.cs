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
    
    public partial class PolicyReinsurance
    {
        public int Id { get; set; }
        public Nullable<int> PolicyVersionId { get; set; }
        public int ReinsuranceContractId { get; set; }
        public decimal SelfRisk { get; set; }
        public decimal SelfPremium { get; set; }
        public decimal TreatRisk { get; set; }
        public decimal TreatPremium { get; set; }
        public decimal FacultativeRisk { get; set; }
        public decimal FacultativePremium { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreateUserid { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
    
        public virtual PolicyVersion PolicyVersion { get; set; }
        public virtual ReinsuranceContract ReinsuranceContract { get; set; }
    }
}
