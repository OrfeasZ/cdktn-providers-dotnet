using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookVersionExecutionWorkflowDetails), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionExecutionWorkflowDetails")]
    public interface IFleetAppsManagementRunbookVersionExecutionWorkflowDetails
    {
        /// <summary>workflow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_apps_management_runbook_version#workflow FleetAppsManagementRunbookVersion#workflow}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionExecutionWorkflowDetailsWorkflow" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "workflow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionExecutionWorkflowDetailsWorkflow\"},\"kind\":\"array\"}}]}}")]
        object Workflow
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookVersionExecutionWorkflowDetails), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionExecutionWorkflowDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionExecutionWorkflowDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>workflow block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_apps_management_runbook_version#workflow FleetAppsManagementRunbookVersion#workflow}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionExecutionWorkflowDetailsWorkflow" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "workflow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionExecutionWorkflowDetailsWorkflow\"},\"kind\":\"array\"}}]}}")]
            public object Workflow
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
