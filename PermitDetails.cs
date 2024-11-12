using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epermit.Models
{
    public class PermitDetails
    {
        public string Permit_Issue_ID { get; set; }
        public string Permit_Issue_No { get; set; }
        public string IssuedByDeparment { get; set; }
        public string IssuedByArea { get; set; }
        public string JobDescription { get; set; }
        public string PermitShift { get; set; }
        public bool IsGasTestRequired { get; set; }
        public string PermitIssueDate { get; set; }
        public string IssuedToDeparment { get; set; }
        public string IssuedToArea { get; set; }
        public string LocationOfWork { get; set; }
        public bool IsPermitToBeRecievedByIndividual { get; set; }

        public bool WithSAPnotification { get; set; }
        public bool WithSAPPMONotification { get; set; }
        public bool WithSAPPMsuborder { get; set; }
        public bool WithuoutSAPnotification { get; set; }
        public string ReasonForWithoutSAPnotification { get; set; }
        public bool WithWorkOrderNumber { get; set; }
        public bool WithoutWorkOrderNumber { get; set; }
        public string ReasonForWithoutWorkOrderNumber { get; set; }
        public bool IsPermitReceived { get; set; }
     
    }
}