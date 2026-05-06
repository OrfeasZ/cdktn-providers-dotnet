using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookVersionTasksOutputVariableMappings), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksOutputVariableMappings")]
    public interface IFleetAppsManagementRunbookVersionTasksOutputVariableMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#name FleetAppsManagementRunbookVersion#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>output_variable_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#output_variable_details FleetAppsManagementRunbookVersion#output_variable_details}
        /// </remarks>
        [JsiiProperty(name: "outputVariableDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails\"}")]
        oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails OutputVariableDetails
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookVersionTasksOutputVariableMappings), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksOutputVariableMappings")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksOutputVariableMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#name FleetAppsManagementRunbookVersion#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>output_variable_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#output_variable_details FleetAppsManagementRunbookVersion#output_variable_details}
            /// </remarks>
            [JsiiProperty(name: "outputVariableDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails\"}")]
            public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails OutputVariableDetails
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails>()!;
            }
        }
    }
}
