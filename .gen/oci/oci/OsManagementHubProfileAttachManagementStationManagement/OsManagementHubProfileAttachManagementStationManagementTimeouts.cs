using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubProfileAttachManagementStationManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubProfileAttachManagementStationManagement.OsManagementHubProfileAttachManagementStationManagementTimeouts")]
    public class OsManagementHubProfileAttachManagementStationManagementTimeouts : oci.OsManagementHubProfileAttachManagementStationManagement.IOsManagementHubProfileAttachManagementStationManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_management_station_management#create OsManagementHubProfileAttachManagementStationManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_management_station_management#delete OsManagementHubProfileAttachManagementStationManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_management_station_management#update OsManagementHubProfileAttachManagementStationManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
