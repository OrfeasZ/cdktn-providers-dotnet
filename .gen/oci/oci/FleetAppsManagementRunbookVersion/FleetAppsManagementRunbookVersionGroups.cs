using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroups")]
    public class FleetAppsManagementRunbookVersionGroups : oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#name FleetAppsManagementRunbookVersion#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#type FleetAppsManagementRunbookVersion#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#properties FleetAppsManagementRunbookVersion#properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsProperties\"}", isOptional: true)]
        public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsProperties? Properties
        {
            get;
            set;
        }
    }
}
