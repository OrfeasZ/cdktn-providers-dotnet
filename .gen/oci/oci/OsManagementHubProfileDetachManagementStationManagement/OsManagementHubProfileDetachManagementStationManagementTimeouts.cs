using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubProfileDetachManagementStationManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubProfileDetachManagementStationManagement.OsManagementHubProfileDetachManagementStationManagementTimeouts")]
    public class OsManagementHubProfileDetachManagementStationManagementTimeouts : oci.OsManagementHubProfileDetachManagementStationManagement.IOsManagementHubProfileDetachManagementStationManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_profile_detach_management_station_management#create OsManagementHubProfileDetachManagementStationManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_profile_detach_management_station_management#delete OsManagementHubProfileDetachManagementStationManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_profile_detach_management_station_management#update OsManagementHubProfileDetachManagementStationManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
