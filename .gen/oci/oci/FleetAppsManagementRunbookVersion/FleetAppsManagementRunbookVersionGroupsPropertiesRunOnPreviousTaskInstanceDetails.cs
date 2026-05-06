using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesRunOnPreviousTaskInstanceDetails")]
    public class FleetAppsManagementRunbookVersionGroupsPropertiesRunOnPreviousTaskInstanceDetails : oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesRunOnPreviousTaskInstanceDetails
    {
        /// <summary>output_variable_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#output_variable_details FleetAppsManagementRunbookVersion#output_variable_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputVariableDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails\"}", isOptional: true)]
        public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesRunOnPreviousTaskInstanceDetailsOutputVariableDetails? OutputVariableDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#resource_id FleetAppsManagementRunbookVersion#resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#resource_type FleetAppsManagementRunbookVersion#resource_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceType
        {
            get;
            set;
        }
    }
}
