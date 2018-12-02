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
    
    public partial class PackageService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PackageService()
        {
            this.PackageService1 = new HashSet<PackageService>();
        }
    
        public int Id { get; set; }
        public int PackageId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<bool> IsMainProductService { get; set; }
        public Nullable<bool> IsPrintService { get; set; }
        public Nullable<decimal> PercentLimit { get; set; }
        public Nullable<decimal> Limit { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> IsFor { get; set; }
        public Nullable<int> WaitingDayCount { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHidden { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> ZoneId { get; set; }
    
        public virtual Package Package { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackageService> PackageService1 { get; set; }
        public virtual PackageService PackageService2 { get; set; }
        public virtual SubProduct SubProduct { get; set; }
        public virtual Service Service { get; set; }
    }
}
