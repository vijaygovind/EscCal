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
    
    public partial class TxnCaseNonStandardTrackSystem
    {
        public int NonStandardTrackId { get; set; }
        public string GuideName { get; set; }
        public Nullable<int> CaseVersionId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<float> DistanceOfTrackSupport { get; set; }
        public Nullable<float> CrossSectionDrawing { get; set; }
        public Nullable<float> DeadWeight { get; set; }
        public Nullable<float> AreaMomentOfInertia { get; set; }
        public Nullable<float> SectionModulus { get; set; }
        public Nullable<float> YoungsModulus { get; set; }
        public Nullable<bool> IsBlueComponent { get; set; }
        public Nullable<bool> IsTempConfig { get; set; }
        public string Comment { get; set; }
    
        public virtual MasterProduct MasterProduct { get; set; }
        public virtual TxnCaseVersion TxnCaseVersion { get; set; }
    }
}
