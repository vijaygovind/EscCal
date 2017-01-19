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
    
    public partial class TxnCaseNonStandardGearbox
    {
        public int NonStandardGearId { get; set; }
        public string GearboxName { get; set; }
        public Nullable<int> CaseVersionId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string GearboxType { get; set; }
        public Nullable<float> PartNo { get; set; }
        public Nullable<float> GearRatio { get; set; }
        public Nullable<float> EfficencyAtFullLoad { get; set; }
        public Nullable<float> DeadWeightOfGearBox { get; set; }
        public Nullable<bool> IsBlueComponent { get; set; }
        public Nullable<bool> IsTempConfig { get; set; }
        public string Comment { get; set; }
    
        public virtual MasterProduct MasterProduct { get; set; }
        public virtual TxnCaseVersion TxnCaseVersion { get; set; }
    }
}