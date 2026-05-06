using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksOutputVariableMappings")]
    public class FleetAppsManagementRunbookVersionTasksOutputVariableMappings : oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksOutputVariableMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#name FleetAppsManagementRunbookVersion#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>output_variable_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#output_variable_details FleetAppsManagementRunbookVersion#output_variable_details}
        /// </remarks>
        [JsiiProperty(name: "outputVariableDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails\"}")]
        public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksOutputVariableMappingsOutputVariableDetails OutputVariableDetails
        {
            get;
            set;
        }
    }
}
