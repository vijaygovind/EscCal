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
    
    public partial class MasterRatedLoad
    {
        public int RatedLoadId { get; set; }
        public Nullable<int> InclinationId { get; set; }
        public Nullable<int> StepWidthId { get; set; }
        public Nullable<float> RatedLoadWeight { get; set; }
    
        public virtual MasterInclination MasterInclination { get; set; }
        public virtual MasterNominalStepWidth MasterNominalStepWidth { get; set; }
    }
}
