using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementTaskRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsProperties")]
    public class FleetAppsManagementTaskRecordDetailsProperties : oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#num_retries FleetAppsManagementTaskRecord#num_retries}.</summary>
        [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}")]
        public double NumRetries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#timeout_in_seconds FleetAppsManagementTaskRecord#timeout_in_seconds}.</summary>
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double TimeoutInSeconds
        {
            get;
            set;
        }
    }
}
