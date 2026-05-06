using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsWorkflow")]
    public class FleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsWorkflow : oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsWorkflow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#group_name FleetAppsManagementRunbook#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupName
        {
            get;
            set;
        }

        private object _steps;

        /// <summary>steps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#steps FleetAppsManagementRunbook#steps}
        /// </remarks>
        [JsiiProperty(name: "steps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsWorkflowSteps\"},\"kind\":\"array\"}}]}}")]
        public object Steps
        {
            get => _steps;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsWorkflowSteps[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsWorkflowSteps).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsWorkflowSteps).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _steps = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#type FleetAppsManagementRunbook#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
