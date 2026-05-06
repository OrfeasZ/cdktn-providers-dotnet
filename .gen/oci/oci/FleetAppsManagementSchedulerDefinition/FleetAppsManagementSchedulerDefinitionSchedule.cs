using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementSchedulerDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionSchedule")]
    public class FleetAppsManagementSchedulerDefinitionSchedule : oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#execution_startdate FleetAppsManagementSchedulerDefinition#execution_startdate}.</summary>
        [JsiiProperty(name: "executionStartdate", typeJson: "{\"primitive\":\"string\"}")]
        public string ExecutionStartdate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#type FleetAppsManagementSchedulerDefinition#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#duration FleetAppsManagementSchedulerDefinition#duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#maintenance_window_id FleetAppsManagementSchedulerDefinition#maintenance_window_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceWindowId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#recurrences FleetAppsManagementSchedulerDefinition#recurrences}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recurrences", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Recurrences
        {
            get;
            set;
        }
    }
}
