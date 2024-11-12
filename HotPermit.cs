using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epermit.Models
{
    public class HotPermit
    {
        public string hot_permit_ID { get; set; }
        public string checking { get; set; }
        public string checkingChecklist_String { get; set; }
        public checkingChecklist checkingChecklist { get; set; }


        public string SurroundingARea { get; set; }

        public string hotSurroundingAReaChecklist_String { get; set; }
        public hotSurroundingAReaChecklist hotSurroundingAReaChecklist { get; set; }

        public string SewersManholesCBDandHotSurface { get; set; }

        public string SewersManholesCBDandHotSurfaceChecklist_String { get; set; }
        public SewersManholesCBDandHotSurfaceChecklist SewersManholesCBDandHotSurfaceChecklist { get; set; }


        public string ConsideredHazardFrom { get; set; }
        public string EquipmentElectricallyIsolated { get; set; }
        public string FireWaterhose_PortableExtinguishers { get; set; }
        public string EquipmentProperlyDrained_Depressurized { get; set; }
        public string CheckforOilgas_Trapped { get; set; }
        public string WeldingMachineCheckedfor { get; set; }
        public string EquipmentProperlySteamed_Purged { get; set; }
        public string ShieldAgainstSparks { get; set; }
        public string ProperMeansofExit { get; set; }
        public string IronSulphide { get; set; }
        public string GasTest { get; set; }
        public string ClearanceForDykeWallCutting { get; set; }
        public string ProperTags_Boards { get; set; }

        public string EquipmentWaterFlushed { get; set; }
        public string StandByPersonal_FireWatch { get; set; }
        public string PortableEquipment_Nozzles { get; set; }
        public string StandbyPersonal_VesselEntry { get; set; }
        public string ClearanceForRoadCuttingFromTech_Fire_ConcerenedDept { get; set; }
        public string ClearanceForAreaCivil_Excavation { get; set; }
        public string Equipment { get; set; }
        public string PrecautionAgainstPublicTraffic { get; set; }
        public string VentilationAndLightning { get; set; }
        public string PrecautionaryTags_Boards { get; set; }
        public string AreaCordonedOf { get; set; }
        public string ClearanceForExcavation_Electrical_ConcerenedDept { get; set; }
        public string Flame_SparkArrestor { get; set; }
        public string ppe { get; set; }
      }




    public class checkingChecklist
    {
        public bool Equipment { get; set; }
        public bool Work_area { get; set; }

    }

    public class hotSurroundingAReaChecklist
    {
        public bool Checked { get; set; }
        public bool Rags { get; set; }
        public bool Cleaned_up_oil { get; set; }

        public bool Grass_etc_removed { get; set; }

    }

    public class SewersManholesCBDandHotSurfaceChecklist
    {
        public bool Checked { get; set; }
        public bool Covered { get; set; }
        public bool Cleaned_up { get; set; }

        public bool Removed_debris { get; set; }

    }
}