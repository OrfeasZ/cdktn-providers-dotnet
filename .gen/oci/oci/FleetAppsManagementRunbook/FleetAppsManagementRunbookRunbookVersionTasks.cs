using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasks")]
    public class FleetAppsManagementRunbookRunbookVersionTasks : oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#step_name FleetAppsManagementRunbook#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public string StepName
        {
            get;
            set;
        }

        /// <summary>task_record_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#task_record_details FleetAppsManagementRunbook#task_record_details}
        /// </remarks>
        [JsiiProperty(name: "taskRecordDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails\"}")]
        public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails TaskRecordDetails
        {
            get;
            set;
        }

        private object? _outputVariableMappings;

        /// <summary>output_variable_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#output_variable_mappings FleetAppsManagementRunbook#output_variable_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputVariableMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OutputVariableMappings
        {
            get => _outputVariableMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _outputVariableMappings = value;
            }
        }

        /// <summary>step_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#step_properties FleetAppsManagementRunbook#step_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepProperties", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepProperties\"}", isOptional: true)]
        public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepProperties? StepProperties
        {
            get;
            set;
        }
    }
}
