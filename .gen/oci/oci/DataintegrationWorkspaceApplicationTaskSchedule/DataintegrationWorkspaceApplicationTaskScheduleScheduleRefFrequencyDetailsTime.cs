using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime")]
    public class DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime : oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#hour DataintegrationWorkspaceApplicationTaskSchedule#hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#minute DataintegrationWorkspaceApplicationTaskSchedule#minute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#second DataintegrationWorkspaceApplicationTaskSchedule#second}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "second", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Second
        {
            get;
            set;
        }
    }
}
