using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetails), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetails")]
    public interface IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetails
    {
        /// <summary>output_variable_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#output_variable_details FleetAppsManagementRunbook#output_variable_details}
        /// </remarks>
        [JsiiProperty(name: "outputVariableDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails? OutputVariableDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#resource_id FleetAppsManagementRunbook#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#resource_type FleetAppsManagementRunbook#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetails), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>output_variable_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#output_variable_details FleetAppsManagementRunbook#output_variable_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outputVariableDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails? OutputVariableDetails
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#resource_id FleetAppsManagementRunbook#resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#resource_type FleetAppsManagementRunbook#resource_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
