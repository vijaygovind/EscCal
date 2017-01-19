using System;

namespace EscCalc.Domain.Implementation
{
    public class TxnCaseVersionValuesForTemplate
    {
        public int? CaseversionID { get; set; }
        public int? CalculationID { get; set; }
        public string Project { get; set; }
        public string ProductName { get; set; }
        public float? VerticalRise { get; set; }
        public string GearBoxTypeName { get; set; }
        public float? SafetyFactorGearBox { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public float? PinPressure { get; set; }
        public float? TotalChainLifeTimeElongation { get; set; }
    }
}