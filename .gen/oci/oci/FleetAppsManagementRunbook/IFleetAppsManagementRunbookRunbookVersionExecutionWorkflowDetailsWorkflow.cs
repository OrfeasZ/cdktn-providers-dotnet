using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsWorkflow), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsWorkflow")]
    public interface IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsWorkflow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#group_name FleetAppsManagementRunbook#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
        string GroupName
        {
            get;
        }

        /// <summary>steps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#steps FleetAppsManagementRunbook#steps}
        /// </remarks>
        [JsiiProperty(name: "steps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsWorkflowSteps\"},\"kind\":\"array\"}}]}}")]
        object Steps
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#type FleetAppsManagementRunbook#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsWorkflow), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsWorkflow")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsWorkflow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#group_name FleetAppsManagementRunbook#group_name}.</summary>
            [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>steps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#steps FleetAppsManagementRunbook#steps}
            /// </remarks>
            [JsiiProperty(name: "steps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsWorkflowSteps\"},\"kind\":\"array\"}}]}}")]
            public object Steps
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#type FleetAppsManagementRunbook#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
