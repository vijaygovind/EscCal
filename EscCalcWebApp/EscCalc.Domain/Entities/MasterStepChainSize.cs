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
    
    public partial class MasterStepChainSize
    {
        public int StepChainSizeId { get; set; }
        public string StepChainSizeName { get; set; }
        public string Description { get; set; }
        public Nullable<int> ProductId { get; set; }
    
        public virtual MasterProduct MasterProduct { get; set; }
    }
}
