using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscCalc.Domain.Entities.MyEntities
{
  
    public class FinalCalcParam
    {
        public   float   MotorPower { get; set; }
        public float Deceleration{ get; set; }
        public float SafetyFactorDriveChain{ get; set; }
        public float SafetyFactorGearBox{ get; set; }
        public float ChainLinkSurfacePressure{ get; set; }
        public float StepLoad{ get; set; }
        public float PassengerStepLoad{ get; set; }
        public float BrakeTimeWithoutBrakeIncidenceTime{ get; set; }
        public float BrakeTimeWithBrakeIncidenceTime{ get; set; }
        public float TorqueGearBoxOutputShaft{ get; set; }
        public float TorqueMainShaft{ get; set; }
        public float ChainRollerForceNorToTrack{ get; set; }
        public float ChainRollerTrackSupportForce{ get; set; }
        public float StepRollerForceNorToTrack{ get; set; }
        public float TotalDeflection{ get; set; }
        public float SafetyFactorYielding{ get; set; }
        public float PassengerSideChainRollerLoad{ get; set; }
        public float PassengerSideStepRollerLoad{ get; set; }
        public float SafetyFactor{ get; set; }
        public float PinPressure{ get; set; }
        public float TotalChainLifeTimeElongation{ get; set; }
        public float Forces1{ get; set; }
        public float Forces2{ get; set; }
        public float StaticSafetyFactor{ get; set; }
        public float ReactionForceStepChainRoller{ get; set; }
        public float ReactionForcesChainLinkDirection{ get; set; }
        public float ResultantBearingForce{ get; set; }
        public float NominalLifeTime10{ get; set; }
        public float NominalLifeTimeH{ get; set; }
        public float DynamicChainLoad{ get; set; }
        public float LoadCycles{ get; set; }
        public float FatigueLife{ get; set; }
    }
}
