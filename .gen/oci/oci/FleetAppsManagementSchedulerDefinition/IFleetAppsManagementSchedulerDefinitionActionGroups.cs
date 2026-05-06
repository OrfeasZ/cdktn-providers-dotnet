using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementSchedulerDefinition
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementSchedulerDefinitionActionGroups), fullyQualifiedName: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionActionGroups")]
    public interface IFleetAppsManagementSchedulerDefinitionActionGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#fleet_id FleetAppsManagementSchedulerDefinition#fleet_id}.</summary>
        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        string FleetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#kind FleetAppsManagementSchedulerDefinition#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#runbook_id FleetAppsManagementSchedulerDefinition#runbook_id}.</summary>
        [JsiiProperty(name: "runbookId", typeJson: "{\"primitive\":\"string\"}")]
        string RunbookId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#runbook_version_name FleetAppsManagementSchedulerDefinition#runbook_version_name}.</summary>
        [JsiiProperty(name: "runbookVersionName", typeJson: "{\"primitive\":\"string\"}")]
        string RunbookVersionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#display_name FleetAppsManagementSchedulerDefinition#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#sequence FleetAppsManagementSchedulerDefinition#sequence}.</summary>
        [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Sequence
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementSchedulerDefinitionActionGroups), fullyQualifiedName: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionActionGroups")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionActionGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#fleet_id FleetAppsManagementSchedulerDefinition#fleet_id}.</summary>
            [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
            public string FleetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#kind FleetAppsManagementSchedulerDefinition#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#runbook_id FleetAppsManagementSchedulerDefinition#runbook_id}.</summary>
            [JsiiProperty(name: "runbookId", typeJson: "{\"primitive\":\"string\"}")]
            public string RunbookId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#runbook_version_name FleetAppsManagementSchedulerDefinition#runbook_version_name}.</summary>
            [JsiiProperty(name: "runbookVersionName", typeJson: "{\"primitive\":\"string\"}")]
            public string RunbookVersionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#display_name FleetAppsManagementSchedulerDefinition#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#sequence FleetAppsManagementSchedulerDefinition#sequence}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Sequence
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
