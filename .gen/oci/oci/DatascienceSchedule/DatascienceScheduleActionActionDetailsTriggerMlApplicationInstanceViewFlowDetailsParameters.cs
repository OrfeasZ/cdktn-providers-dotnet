using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiByValue(fqn: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters")]
    public class DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters : oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#name DatascienceSchedule#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#value DatascienceSchedule#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
