using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookVersionTasks), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasks")]
    public interface IFleetAppsManagementRunbookVersionTasks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#step_name FleetAppsManagementRunbookVersion#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        string StepName
        {
            get;
        }

        /// <summary>task_record_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#task_record_details FleetAppsManagementRunbookVersion#task_record_details}
        /// </remarks>
        [JsiiProperty(name: "taskRecordDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetails\"}")]
        oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetails TaskRecordDetails
        {
            get;
        }

        /// <summary>output_variable_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#output_variable_mappings FleetAppsManagementRunbookVersion#output_variable_mappings}
        /// </remarks>
        [JsiiProperty(name: "outputVariableMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksOutputVariableMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OutputVariableMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#step_properties FleetAppsManagementRunbookVersion#step_properties}
        /// </remarks>
        [JsiiProperty(name: "stepProperties", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepProperties? StepProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookVersionTasks), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasks")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#step_name FleetAppsManagementRunbookVersion#step_name}.</summary>
            [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
            public string StepName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>task_record_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#task_record_details FleetAppsManagementRunbookVersion#task_record_details}
            /// </remarks>
            [JsiiProperty(name: "taskRecordDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetails\"}")]
            public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetails TaskRecordDetails
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetails>()!;
            }

            /// <summary>output_variable_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#output_variable_mappings FleetAppsManagementRunbookVersion#output_variable_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outputVariableMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksOutputVariableMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OutputVariableMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>step_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#step_properties FleetAppsManagementRunbookVersion#step_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepProperties", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepProperties\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepProperties? StepProperties
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepProperties?>();
            }
        }
    }
}
