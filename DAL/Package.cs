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
    
    public partial class Package
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Package()
        {
            this.PackageServices = new HashSet<PackageService>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Limit { get; set; }
        public Nullable<int> IsFor { get; set; }
        public Nullable<int> WaitingDayCount { get; set; }
        public bool IsTemplate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHidden { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> TranslateDictionaryId { get; set; }
    
        public virtual Dictionary Dictionary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackageService> PackageServices { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}