using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappingsOutputVariableDetails")]
    public class FleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappingsOutputVariableDetails : oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappingsOutputVariableDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#output_variable_name FleetAppsManagementRunbook#output_variable_name}.</summary>
        [JsiiProperty(name: "outputVariableName", typeJson: "{\"primitive\":\"string\"}")]
        public string OutputVariableName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#step_name FleetAppsManagementRunbook#step_name}.</summary>
        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public string StepName
        {
            get;
            set;
        }
    }
}
