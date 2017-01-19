using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscCalc.Domain.Entities.MyEntities
{
    public class CaseProperties 
    {
       
        public string CaseName { get; set; }
        public int CaseId { get; set; }
        public int VersionNumber { get; set; }  
         public int ProductId { get; set; }
        public int ProductReleaseId { get; set; }
        public int VerticalRise { get; set; }
        public float StepbandSpeedId { get; set; }
       public int StepWidthId { get; set; }
       
        public int TrussPackageId { get; set; }
      public int StepChainGuideId { get; set; }
         public int TrussUpperExtensionLength { get; set; }
          public int TrussLowerExtensionLength { get; set; }
            public int InclinationId { get; set; }
        public float HorizontalNoOfStepsUpper { get; set; }
        public float HorizontalNoOfStepsLower { get; set; }
        public float TransitionRadiusUpperPassenger { get; set; }
        public float TransitionRadiusUpperBackTrack { get; set; }
        public float TranstionRadiusLowerBackTrack { get; set; }
 public int StepBandTypeId { get; set; }
 public int StepChainTypeId { get; set; }
 public int StepChainConditionId { get; set; }
 public int SafetyFactorandPinPressureId { get; set; }
 public int DestinationCountryId { get; set; }
 public int EscalatorEnvironmentId { get; set; }
 public int PowerSupplyId { get; set; }
 public int GearBoxTypeId { get; set; }
 public int MainDriveStrandQuantityId { get; set; }
 public int LoadTypeId { get; set; }
 public int MainDriveChainConditionId { get; set; }
 public int SafetyFactor { get; set; }
 public int HandrailTypeId { get; set; }
 public int HandrailDriveTypeId { get; set; }
public bool IsCustomStep { get; set; }
public bool IsCustomStepChain { get; set; }
        public bool IsCustomTrackSystem { get; set; }
        public bool IsCustomGearbox { get; set; }
        public bool IsCustomHandrail { get; set; }
        public bool IsFreezed { get; set; }
        public bool IsAdvancedCheck { get; set; }
        public string Report { get; set; }
public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public bool IsEditable { get; set; }
    public string Comments { get; set; }

        public int Total { get; set; }
        public int source { get; set; }
        public string ProductName { get; set; }
        public float? StepbandSpeed { get; set; }
        public int? StepWidth { get; set; }
        public string TrussPackage { get; set; }
        public string GuideName { get; set; }
        public float? InclinationAngle { get; set; }
        public float? TransitionRadiusLowerPassenger { get; set; }
        public string StepMaterialName { get; set; }
        public string StepChainTypeName { get; set; }
        public int WearingFactorId { get; set; }
        public string CountryName { get; set; }
        public string EnvironmentTypeName { get;  set; }
        public string Description { get; set; }
        public string GearBoxTypeName { get; set; }
        public string StrandQuantity { get; set; }
        public string Name { get; set; }
        public string PoweSupplyDescription { get; set; }
        public string HandrailDriveTypeName { get; set; }
        public string Project { get; set; }
        public int GuideId { get; set; }
        public int StepMaterialId { get;  set; }
    }
}
