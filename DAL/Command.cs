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
    
    public partial class Command
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Command()
        {
            this.ContractCommands = new HashSet<ContractCommand>();
            this.Command1 = new HashSet<Command>();
            this.CommandEmployes = new HashSet<CommandEmploye>();
            this.PolicyPaymentCoverContractCommands = new HashSet<PolicyPaymentCoverContractCommand>();
        }
    
        public int Id { get; set; }
        public string CommandNo { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool IsAnnulated { get; set; }
        public Nullable<System.DateTime> AnnulatedDate { get; set; }
        public string AnnulatedComment { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHidden { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> LastModifiedUserId { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> CommandChangeLogId { get; set; }
        public Nullable<int> ParentCommandLogId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractCommand> ContractCommands { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Command> Command1 { get; set; }
        public virtual Command Command2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommandEmploye> CommandEmployes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyPaymentCoverContractCommand> PolicyPaymentCoverContractCommands { get; set; }
    }
}