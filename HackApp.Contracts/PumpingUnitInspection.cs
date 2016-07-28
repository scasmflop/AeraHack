using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackApp.Contracts
{
    public class PumpingUnitInspection
    {
        public string Asset { get; set; }
        public int WellFacId { get; set; }
        public string WellName { get; set; }
        public DateTime InspectionDate { get; set; }
        public string UnitSAPNumber { get; set; }
        public string UnitManufacturer { get; set; }
        public string UnitSerialNumber { get; set; }
        public string UnitAPISize { get; set; }
        public string UnitStyle { get; set; }
        public string MotorSAPNumber { get; set; }
        public string MotorManufacturer { get; set; }
        public string MotorSerialNumber { get; set; }
        public string MotorHorsepower { get; set; }
        public string MotorFrameSize { get; set; }
        public string MotorRPM { get; set; }
        public string MotorSheaveSize { get; set; }
        public string MotorNumberOfBelts { get; set; }
        public string MotorBeltSize { get; set; }
        public string GearboxSAPNumber { get; set; }
        public string GearboxSerialNumber { get; set; }
        public string GearboxSheaveSize { get; set; }
        public string GearboxReductionRatio { get; set; }
        public InspectionItem GearboxInspectionItem { get; set; }
        public InspectionItem CranksInspectionItem { get; set; }
        public InspectionItem CounterweightsInspectionItem { get; set; }
        public InspectionItem LeftWristpinInspectionItem { get; set; }
        public InspectionItem RightWristpinInspectionItem { get; set; }
        public InspectionItem CenterBearingInspectionItem { get; set; }
        public InspectionItem EqualizerBearingInspectionItem { get; set; }
        public InspectionItem BeamInspectionItem { get; set; }
        public InspectionItem PitmanArmsInspectionItem { get; set; }
        public InspectionItem SampsonPostInspectionItem { get; set; }
        public InspectionItem LadderInspectionItem { get; set; }
        public InspectionItem HeadInspectionItem { get; set; }
        public InspectionItem BridleInspectionItem { get; set; }
        public InspectionItem GreaseLinesInspectionItem { get; set; }
        public InspectionItem BeltGuardInspectionItem { get; set; }
        public InspectionItem BeltsInspectionItem { get; set; }
        public InspectionItem MotorInspectionItem { get; set; }
        public InspectionItem BrakeInspectionItem { get; set; }
        public InspectionItem UnitGuardInspectionItem { get; set; }
        public InspectionItem StructureBoltsInspectionItem { get; set; }
        public InspectionItem UnitPadInspectionItem { get; set; }
        public InspectionItem ElectricPanelInspectionItem { get; set; }
    }
}