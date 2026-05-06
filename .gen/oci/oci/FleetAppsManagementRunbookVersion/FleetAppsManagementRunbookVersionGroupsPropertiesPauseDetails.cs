using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails")]
    public class FleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails : oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionGroupsPropertiesPauseDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#kind FleetAppsManagementRunbookVersion#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#duration_in_minutes FleetAppsManagementRunbookVersion#duration_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "durationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DurationInMinutes
        {
            get;
            set;
        }
    }
}
