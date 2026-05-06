using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementSchedulerDefinition
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementSchedulerDefinitionRunBooks), fullyQualifiedName: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooks")]
    public interface IFleetAppsManagementSchedulerDefinitionRunBooks
    {
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

        /// <summary>input_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#input_parameters FleetAppsManagementSchedulerDefinition#input_parameters}
        /// </remarks>
        [JsiiProperty(name: "inputParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooksInputParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InputParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementSchedulerDefinitionRunBooks), fullyQualifiedName: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooks")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionRunBooks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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

            /// <summary>input_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#input_parameters FleetAppsManagementSchedulerDefinition#input_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooksInputParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InputParameters
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
