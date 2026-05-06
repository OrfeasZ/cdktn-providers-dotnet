using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementSchedulerDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooks")]
    public class FleetAppsManagementSchedulerDefinitionRunBooks : oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionRunBooks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#runbook_id FleetAppsManagementSchedulerDefinition#runbook_id}.</summary>
        [JsiiProperty(name: "runbookId", typeJson: "{\"primitive\":\"string\"}")]
        public string RunbookId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#runbook_version_name FleetAppsManagementSchedulerDefinition#runbook_version_name}.</summary>
        [JsiiProperty(name: "runbookVersionName", typeJson: "{\"primitive\":\"string\"}")]
        public string RunbookVersionName
        {
            get;
            set;
        }

        private object? _inputParameters;

        /// <summary>input_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#input_parameters FleetAppsManagementSchedulerDefinition#input_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooksInputParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InputParameters
        {
            get => _inputParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionRunBooksInputParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionRunBooksInputParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inputParameters = value;
            }
        }
    }
}
