using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionExecutionWorkflowDetails")]
    public class FleetAppsManagementRunbookVersionExecutionWorkflowDetails : oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionExecutionWorkflowDetails
    {
        private object _workflow;

        /// <summary>workflow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#workflow FleetAppsManagementRunbookVersion#workflow}
        /// </remarks>
        [JsiiProperty(name: "workflow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionExecutionWorkflowDetailsWorkflow\"},\"kind\":\"array\"}}]}}")]
        public object Workflow
        {
            get => _workflow;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionExecutionWorkflowDetailsWorkflow[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionExecutionWorkflowDetailsWorkflow).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionExecutionWorkflowDetailsWorkflow).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _workflow = value;
            }
        }
    }
}
