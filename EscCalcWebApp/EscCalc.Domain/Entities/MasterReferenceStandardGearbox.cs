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
    
    public partial class MasterReferenceStandardGearbox
    {
        public int StandardGearId { get; set; }
        public Nullable<int> GearBoxId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> ProductreleaseId { get; set; }
        public string GearboxType { get; set; }
        public Nullable<int> PartNo { get; set; }
        public string GearRatio { get; set; }
        public string EfficencyAtFullLoad { get; set; }
        public Nullable<float> DeadWeightOfGearBox { get; set; }
    
        public virtual MasterGearboxType MasterGearboxType { get; set; }
        public virtual MasterProduct MasterProduct { get; set; }
        public virtual MasterProductRelease MasterProductRelease { get; set; }
    }
}