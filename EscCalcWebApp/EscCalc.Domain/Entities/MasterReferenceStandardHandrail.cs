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
    
    public partial class MasterReferenceStandardHandrail
    {
        public int StandardHandrailId { get; set; }
        public string HandrailName { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> ProductreleaseId { get; set; }
        public Nullable<float> VerticalRise { get; set; }
        public Nullable<float> HandrailTypeShape { get; set; }
        public Nullable<float> DiameterOfHandrailDriveWheel { get; set; }
        public Nullable<float> EffectiveDiameterOfHandrailDriveWheel { get; set; }
        public Nullable<int> NumberOfTeethHandrailDriveSprocketAtMainShaft { get; set; }
        public Nullable<int> NumberOfTeethHandrailDriveSprocketAtHandrailShaft { get; set; }
        public Nullable<int> NumberOfTeethHandrailDriveSprocketAtJackShaft { get; set; }
        public Nullable<int> NumberOfTeethHandrailDriveSprocketAtNewelEnd { get; set; }
    
        public virtual MasterProduct MasterProduct { get; set; }
        public virtual MasterProductRelease MasterProductRelease { get; set; }
    }
}
