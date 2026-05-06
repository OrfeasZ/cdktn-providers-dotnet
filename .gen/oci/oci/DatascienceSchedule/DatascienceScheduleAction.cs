using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceSchedule.DatascienceScheduleAction")]
    public class DatascienceScheduleAction : oci.DatascienceSchedule.IDatascienceScheduleAction
    {
        /// <summary>action_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#action_details DatascienceSchedule#action_details}
        /// </remarks>
        [JsiiProperty(name: "actionDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetails\"}")]
        public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails ActionDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#action_type DatascienceSchedule#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionType
        {
            get;
            set;
        }
    }
}
