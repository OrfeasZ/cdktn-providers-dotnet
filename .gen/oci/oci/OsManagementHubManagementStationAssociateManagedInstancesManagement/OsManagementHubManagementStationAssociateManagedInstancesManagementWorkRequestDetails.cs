using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagementStationAssociateManagedInstancesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagementStationAssociateManagedInstancesManagement.OsManagementHubManagementStationAssociateManagedInstancesManagementWorkRequestDetails")]
    public class OsManagementHubManagementStationAssociateManagedInstancesManagementWorkRequestDetails : oci.OsManagementHubManagementStationAssociateManagedInstancesManagement.IOsManagementHubManagementStationAssociateManagedInstancesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_associate_managed_instances_management#description OsManagementHubManagementStationAssociateManagedInstancesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_associate_managed_instances_management#display_name OsManagementHubManagementStationAssociateManagedInstancesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
