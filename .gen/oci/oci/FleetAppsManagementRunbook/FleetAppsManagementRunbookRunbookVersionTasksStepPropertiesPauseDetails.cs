using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesPauseDetails")]
    public class FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesPauseDetails : oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesPauseDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#kind FleetAppsManagementRunbook#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#duration_in_minutes FleetAppsManagementRunbook#duration_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "durationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DurationInMinutes
        {
            get;
            set;
        }
    }
}
