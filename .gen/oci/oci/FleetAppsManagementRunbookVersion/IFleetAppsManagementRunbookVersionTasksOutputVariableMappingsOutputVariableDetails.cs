using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails")]
    public interface IFleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#output_variable_name FleetAppsManagementRunbookVersion#output_variable_name}.</summary>
        [JsiiProperty(name: "outputVariableName", typeJson: "{\"primitive\":\"string\"}")]
        string OutputVariableName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#step_name FleetAppsManagementRunbookVersion#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        string StepName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#output_variable_name FleetAppsManagementRunbookVersion#output_variable_name}.</summary>
            [JsiiProperty(name: "outputVariableName", typeJson: "{\"primitive\":\"string\"}")]
            public string OutputVariableName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#step_name FleetAppsManagementRunbookVersion#step_name}.</summary>
            [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
            public string StepName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
