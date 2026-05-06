using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementSchedulerDefinition
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementSchedulerDefinitionRunBooksInputParameters), fullyQualifiedName: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooksInputParameters")]
    public interface IFleetAppsManagementSchedulerDefinitionRunBooksInputParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#step_name FleetAppsManagementSchedulerDefinition#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        string StepName
        {
            get;
        }

        /// <summary>arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#arguments FleetAppsManagementSchedulerDefinition#arguments}
        /// </remarks>
        [JsiiProperty(name: "arguments", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooksInputParametersArguments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Arguments
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementSchedulerDefinitionRunBooksInputParameters), fullyQualifiedName: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooksInputParameters")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionRunBooksInputParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#step_name FleetAppsManagementSchedulerDefinition#step_name}.</summary>
            [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
            public string StepName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>arguments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#arguments FleetAppsManagementSchedulerDefinition#arguments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "arguments", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooksInputParametersArguments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Arguments
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
