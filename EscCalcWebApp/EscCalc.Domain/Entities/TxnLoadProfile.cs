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
    
    public partial class TxnLoadProfile
    {
        public int LoadProfileId { get; set; }
        public Nullable<int> CaseVersionId { get; set; }
        public Nullable<float> P1 { get; set; }
        public Nullable<float> P2 { get; set; }
        public Nullable<float> P3 { get; set; }
        public Nullable<float> P4 { get; set; }
        public Nullable<float> P5 { get; set; }
        public Nullable<float> Q1 { get; set; }
        public Nullable<float> Q2 { get; set; }
        public Nullable<float> Q3 { get; set; }
        public Nullable<float> Q4 { get; set; }
        public Nullable<float> Q5 { get; set; }
    
        public virtual TxnCaseVersion TxnCaseVersion { get; set; }
    }
}
