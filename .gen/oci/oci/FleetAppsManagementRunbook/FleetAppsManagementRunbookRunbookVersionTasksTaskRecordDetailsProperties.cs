using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties")]
    public class FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties : oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#num_retries FleetAppsManagementRunbook#num_retries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumRetries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#timeout_in_seconds FleetAppsManagementRunbook#timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutInSeconds
        {
            get;
            set;
        }
    }
}
