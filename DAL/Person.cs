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
    
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            this.Contracts = new HashSet<Contract>();
            this.Contracts1 = new HashSet<Contract>();
            this.Person1 = new HashSet<Person>();
            this.PolicyVersions = new HashSet<PolicyVersion>();
            this.PolicyVersions1 = new HashSet<PolicyVersion>();
            this.PolicyVersions2 = new HashSet<PolicyVersion>();
            this.PolicyVersions3 = new HashSet<PolicyVersion>();
            this.PolicyVersions4 = new HashSet<PolicyVersion>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string FirstNameEng { get; set; }
        public string LastnameEng { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<int> GenderId { get; set; }
        public string PersonNo { get; set; }
        public string PassportNo { get; set; }
        public Nullable<System.DateTime> PassportValidDate { get; set; }
        public Nullable<System.DateTime> IdentityCardValidDate { get; set; }
        public bool IsPoliticallyActivePerson { get; set; }
        public Nullable<int> CitizenshipCountryId { get; set; }
        public Nullable<int> ResidenceCountryId { get; set; }
        public Nullable<int> PersonTypeId { get; set; }
        public Nullable<int> LegalStatusId { get; set; }
        public Nullable<int> RegistrationCountryId { get; set; }
        public Nullable<int> IncomeRangeId { get; set; }
        public Nullable<int> OrganizationStatusId { get; set; }
        public Nullable<int> OrganizationStructureId { get; set; }
        public Nullable<int> CustomerStatusId { get; set; }
        public Nullable<int> SocialStatusId { get; set; }
        public Nullable<int> OrganizationRiskId { get; set; }
        public Nullable<int> PersonBlackListId { get; set; }
        public string RegistratorOrganization { get; set; }
        public string RegistrationNo { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public string IdentityNumber { get; set; }
        public Nullable<bool> IsDeath { get; set; }
        public Nullable<System.DateTime> DeathDate { get; set; }
        public Nullable<bool> IsBlack { get; set; }
        public Nullable<bool> IsOwnerCompany { get; set; }
        public Nullable<bool> IsGovernment { get; set; }
        public string Mail { get; set; }
        public Nullable<System.Guid> SupervisionPersonId { get; set; }
        public Nullable<int> MaritalStatysId { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHidden { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public Nullable<int> PersonChangeLogId { get; set; }
        public Nullable<int> AuthorizationUserId { get; set; }
        public Nullable<System.DateTime> UserAuthorizationDate { get; set; }
        public bool IsAuthorized { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Person1 { get; set; }
        public virtual Person Person2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyVersion> PolicyVersions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyVersion> PolicyVersions1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyVersion> PolicyVersions2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyVersion> PolicyVersions3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyVersion> PolicyVersions4 { get; set; }
    }
}
