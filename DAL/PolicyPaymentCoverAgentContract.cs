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
    
    public partial class PolicyPaymentCoverAgentContract
    {
        public int Id { get; set; }
        public int AgentContractId { get; set; }
        public int PolicyVersionId { get; set; }
        public int PayCount { get; set; }
        public System.DateTime PayDate { get; set; }
        public decimal Amount { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public Nullable<bool> IsPayd { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
    
        public virtual ContractAgentContract ContractAgentContract { get; set; }
        public virtual PolicyVersion PolicyVersion { get; set; }
    }
}
