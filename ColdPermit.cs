using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epermit.Models
{
    public class ColdPermit
    {
        public string permitId { get; set; }
        public string cold_permit_ID{ get; set; }
        public string WorkAreaInspected { get; set; }
        
        public string SurroundingARea { get; set; }
        public SurroundingAReaChecklist SurroundingAReaChecklist { get; set; }

        
        public string EquipmentElectricallyIsolated { get; set; }

        public string RunningWater { get; set; }
        public string RunningWaterChecklist_String { get; set; }
        public RunningWaterChecklist RunningWaterChecklist { get; set; }

        public string Equipment { get; set; }

        public string EquipmentChecklist_String { get; set; }
        public EquipmentChecklist EquipmentChecklist { get; set; }
        public string EquipmentProperty { get; set; }
        public string EquipmentPropertyChecklist_String { get; set; }
        public EquipmentPropertyChecklist EquipmentPropertyChecklist { get; set; }
        public string EquipmentWaterFlushed { get; set; }
        public string IronSulphide { get; set; }
        public string EquipmentProperlySteamed { get; set; }
        public string GasTest { get; set; }
        public string StandbyPerson { get; set; }
        public string VentilationandLighting { get; set; }
        public string AreaCordoned { get; set; }
        public string RadioIsotopes { get; set; }
        public string ppe { get; set; }
    }

    public class SurroundingAReaChecklist
    {
        public bool Checked { get; set; }
        public bool Covered { get; set; }
        public bool Cleaned { get; set; }

    }

    public class RunningWaterChecklist
    {
        public bool Checked { get; set; }
        public bool Covered { get; set; }
        public bool Cleaned { get; set; }

    }

    public class EquipmentChecklist
    {
        public bool Blinded { get; set; }
        public bool Closed { get; set; }
        public bool Disconnected { get; set; }

        public bool Isolated { get; set; }


    }

    public class EquipmentPropertyChecklist
    {
        public bool Drained { get; set; }
        public bool Depressurised { get; set; }

    }


}
