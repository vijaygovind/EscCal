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
    
    public partial class MasterHandrailDriveType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterHandrailDriveType()
        {
            this.TxnCaseVersions = new HashSet<TxnCaseVersion>();
        }
    
        public int HandrailDriveTypeId { get; set; }
        public string HandrailDriveTypeName { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TxnCaseVersion> TxnCaseVersions { get; set; }
    }
}
