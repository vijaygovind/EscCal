//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscCalc.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TxnCase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TxnCase()
        {
            this.TxnCaseVersions = new HashSet<TxnCaseVersion>();
            this.TxnCaseVersions1 = new HashSet<TxnCaseVersion>();
        }
    
        public int CaseId { get; set; }
        public string CaseName { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> Source { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TxnCaseVersion> TxnCaseVersions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TxnCaseVersion> TxnCaseVersions1 { get; set; }
    }
}
