using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagementStationMirrorSynchronizeManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagementStationMirrorSynchronizeManagement.OsManagementHubManagementStationMirrorSynchronizeManagementTimeouts")]
    public class OsManagementHubManagementStationMirrorSynchronizeManagementTimeouts : oci.OsManagementHubManagementStationMirrorSynchronizeManagement.IOsManagementHubManagementStationMirrorSynchronizeManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_mirror_synchronize_management#create OsManagementHubManagementStationMirrorSynchronizeManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_mirror_synchronize_management#delete OsManagementHubManagementStationMirrorSynchronizeManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_mirror_synchronize_management#update OsManagementHubManagementStationMirrorSynchronizeManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
