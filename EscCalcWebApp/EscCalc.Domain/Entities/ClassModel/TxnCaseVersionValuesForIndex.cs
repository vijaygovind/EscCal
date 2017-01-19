using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscCalc.Domain.Entities.ClassModel
{
   public class TxnCaseVersionValuesForIndex
    {
        public string CaseName { get; set; }
        public int? VersionNumber { get; set; }
        public string Project { get; set; }
        public string ProductName { get; set; }
        public float? VerticalRise { get; set; }
        public string TrussPackageName { get; set; }
        public int? StepWidth { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Action { get; set; }
        public string Link { get; set; }
    }
}
