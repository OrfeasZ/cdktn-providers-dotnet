using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagementStationAssociateManagedInstancesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagementStationAssociateManagedInstancesManagement.OsManagementHubManagementStationAssociateManagedInstancesManagementTimeouts")]
    public class OsManagementHubManagementStationAssociateManagedInstancesManagementTimeouts : oci.OsManagementHubManagementStationAssociateManagedInstancesManagement.IOsManagementHubManagementStationAssociateManagedInstancesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_associate_managed_instances_management#create OsManagementHubManagementStationAssociateManagedInstancesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_associate_managed_instances_management#delete OsManagementHubManagementStationAssociateManagedInstancesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_associate_managed_instances_management#update OsManagementHubManagementStationAssociateManagedInstancesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
