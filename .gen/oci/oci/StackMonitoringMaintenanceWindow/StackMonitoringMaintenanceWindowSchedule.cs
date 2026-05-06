using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMaintenanceWindow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMaintenanceWindow.StackMonitoringMaintenanceWindowSchedule")]
    public class StackMonitoringMaintenanceWindowSchedule : oci.StackMonitoringMaintenanceWindow.IStackMonitoringMaintenanceWindowSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#schedule_type StackMonitoringMaintenanceWindow#schedule_type}.</summary>
        [JsiiProperty(name: "scheduleType", typeJson: "{\"primitive\":\"string\"}")]
        public string ScheduleType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#maintenance_window_duration StackMonitoringMaintenanceWindow#maintenance_window_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceWindowDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#maintenance_window_recurrences StackMonitoringMaintenanceWindow#maintenance_window_recurrences}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowRecurrences", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceWindowRecurrences
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#time_maintenance_window_end StackMonitoringMaintenanceWindow#time_maintenance_window_end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeMaintenanceWindowEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeMaintenanceWindowEnd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#time_maintenance_window_start StackMonitoringMaintenanceWindow#time_maintenance_window_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeMaintenanceWindowStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeMaintenanceWindowStart
        {
            get;
            set;
        }
    }
}
