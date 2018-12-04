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
    
    public partial class PolicyContractPackageService
    {
        public int Id { get; set; }
        public int PolicyContractPackageId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> ContractPackageServiceId { get; set; }
        public Nullable<bool> IsMainProductService { get; set; }
        public Nullable<int> IsFor { get; set; }
        public Nullable<decimal> PercentLimit { get; set; }
        public Nullable<decimal> BlockedAmount { get; set; }
        public Nullable<decimal> Limit { get; set; }
        public Nullable<decimal> SpentMoney { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> ClaimLimitCount { get; set; }
        public Nullable<int> LeftClaimLimitCount { get; set; }
        public Nullable<int> BlockClaimLimitCount { get; set; }
        public Nullable<int> ContractPackageServiceParentId { get; set; }
    
        public virtual ContractPackageService ContractPackageService { get; set; }
        public virtual PolicyContractPackage PolicyContractPackage { get; set; }
        public virtual SubProduct SubProduct { get; set; }
    }
}
