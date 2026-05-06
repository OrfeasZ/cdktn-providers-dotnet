using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersion), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersion")]
    public interface IFleetAppsManagementRunbookRunbookVersion
    {
        /// <summary>execution_workflow_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#execution_workflow_details FleetAppsManagementRunbook#execution_workflow_details}
        /// </remarks>
        [JsiiProperty(name: "executionWorkflowDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails\"}")]
        oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails ExecutionWorkflowDetails
        {
            get;
        }

        /// <summary>groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#groups FleetAppsManagementRunbook#groups}
        /// </remarks>
        [JsiiProperty(name: "groups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionGroups\"},\"kind\":\"array\"}}]}}")]
        object Groups
        {
            get;
        }

        /// <summary>tasks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#tasks FleetAppsManagementRunbook#tasks}
        /// </remarks>
        [JsiiProperty(name: "tasks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasks\"},\"kind\":\"array\"}}]}}")]
        object Tasks
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#is_latest FleetAppsManagementRunbook#is_latest}.</summary>
        [JsiiProperty(name: "isLatest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsLatest
        {
            get
            {
                return null;
            }
        }

        /// <summary>rollback_workflow_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#rollback_workflow_details FleetAppsManagementRunbook#rollback_workflow_details}
        /// </remarks>
        [JsiiProperty(name: "rollbackWorkflowDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails? RollbackWorkflowDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#version FleetAppsManagementRunbook#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersion), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersion")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>execution_workflow_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#execution_workflow_details FleetAppsManagementRunbook#execution_workflow_details}
            /// </remarks>
            [JsiiProperty(name: "executionWorkflowDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails\"}")]
            public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails ExecutionWorkflowDetails
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails>()!;
            }

            /// <summary>groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#groups FleetAppsManagementRunbook#groups}
            /// </remarks>
            [JsiiProperty(name: "groups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionGroups\"},\"kind\":\"array\"}}]}}")]
            public object Groups
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>tasks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#tasks FleetAppsManagementRunbook#tasks}
            /// </remarks>
            [JsiiProperty(name: "tasks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasks\"},\"kind\":\"array\"}}]}}")]
            public object Tasks
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#is_latest FleetAppsManagementRunbook#is_latest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isLatest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsLatest
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>rollback_workflow_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#rollback_workflow_details FleetAppsManagementRunbook#rollback_workflow_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollbackWorkflowDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails? RollbackWorkflowDetails
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#version FleetAppsManagementRunbook#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
