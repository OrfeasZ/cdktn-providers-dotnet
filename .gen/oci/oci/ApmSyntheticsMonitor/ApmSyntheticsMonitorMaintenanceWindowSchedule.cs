using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorMaintenanceWindowSchedule")]
    public class ApmSyntheticsMonitorMaintenanceWindowSchedule : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorMaintenanceWindowSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/apm_synthetics_monitor#recurrence_type ApmSyntheticsMonitor#recurrence_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recurrenceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecurrenceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/apm_synthetics_monitor#schedule_type ApmSyntheticsMonitor#schedule_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduleType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/apm_synthetics_monitor#time_ended ApmSyntheticsMonitor#time_ended}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeEnded
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/apm_synthetics_monitor#time_started ApmSyntheticsMonitor#time_started}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeStarted
        {
            get;
            set;
        }
    }
}
