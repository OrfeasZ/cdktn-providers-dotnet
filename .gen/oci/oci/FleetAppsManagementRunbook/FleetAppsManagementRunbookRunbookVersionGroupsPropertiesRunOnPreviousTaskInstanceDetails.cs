using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionGroupsPropertiesRunOnPreviousTaskInstanceDetails")]
    public class FleetAppsManagementRunbookRunbookVersionGroupsPropertiesRunOnPreviousTaskInstanceDetails : oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionGroupsPropertiesRunOnPreviousTaskInstanceDetails
    {
        /// <summary>output_variable_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#output_variable_details FleetAppsManagementRunbook#output_variable_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputVariableDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionGroupsPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails\"}", isOptional: true)]
        public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionGroupsPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails? OutputVariableDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#resource_id FleetAppsManagementRunbook#resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#resource_type FleetAppsManagementRunbook#resource_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceType
        {
            get;
            set;
        }
    }
}
