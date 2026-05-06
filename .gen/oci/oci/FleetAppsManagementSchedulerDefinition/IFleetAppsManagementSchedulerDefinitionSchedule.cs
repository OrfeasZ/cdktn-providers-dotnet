using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementSchedulerDefinition
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementSchedulerDefinitionSchedule), fullyQualifiedName: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionSchedule")]
    public interface IFleetAppsManagementSchedulerDefinitionSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#execution_startdate FleetAppsManagementSchedulerDefinition#execution_startdate}.</summary>
        [JsiiProperty(name: "executionStartdate", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionStartdate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#type FleetAppsManagementSchedulerDefinition#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#duration FleetAppsManagementSchedulerDefinition#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#maintenance_window_id FleetAppsManagementSchedulerDefinition#maintenance_window_id}.</summary>
        [JsiiProperty(name: "maintenanceWindowId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceWindowId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#recurrences FleetAppsManagementSchedulerDefinition#recurrences}.</summary>
        [JsiiProperty(name: "recurrences", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Recurrences
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementSchedulerDefinitionSchedule), fullyQualifiedName: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionSchedule")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#execution_startdate FleetAppsManagementSchedulerDefinition#execution_startdate}.</summary>
            [JsiiProperty(name: "executionStartdate", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionStartdate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#type FleetAppsManagementSchedulerDefinition#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#duration FleetAppsManagementSchedulerDefinition#duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Duration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#maintenance_window_id FleetAppsManagementSchedulerDefinition#maintenance_window_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindowId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceWindowId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#recurrences FleetAppsManagementSchedulerDefinition#recurrences}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recurrences", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Recurrences
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
