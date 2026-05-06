using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariables")]
    public class FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariables : oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariables
    {
        private object? _inputVariables;

        /// <summary>input_variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#input_variables FleetAppsManagementRunbookVersion#input_variables}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputVariables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InputVariables
        {
            get => _inputVariables;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariables[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariables).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inputVariables = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#output_variables FleetAppsManagementRunbookVersion#output_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OutputVariables
        {
            get;
            set;
        }
    }
}
