using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementTaskRecord
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariables")]
    public class FleetAppsManagementTaskRecordDetailsExecutionDetailsVariables : oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariables
    {
        private object? _inputVariables;

        /// <summary>input_variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#input_variables FleetAppsManagementTaskRecord#input_variables}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputVariables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesInputVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesInputVariables[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesInputVariables).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inputVariables = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#output_variables FleetAppsManagementTaskRecord#output_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OutputVariables
        {
            get;
            set;
        }
    }
}
