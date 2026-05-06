using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagementStationSynchronizeMirrorsManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagementStationSynchronizeMirrorsManagement.OsManagementHubManagementStationSynchronizeMirrorsManagementTimeouts")]
    public class OsManagementHubManagementStationSynchronizeMirrorsManagementTimeouts : oci.OsManagementHubManagementStationSynchronizeMirrorsManagement.IOsManagementHubManagementStationSynchronizeMirrorsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_synchronize_mirrors_management#create OsManagementHubManagementStationSynchronizeMirrorsManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_synchronize_mirrors_management#delete OsManagementHubManagementStationSynchronizeMirrorsManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_synchronize_mirrors_management#update OsManagementHubManagementStationSynchronizeMirrorsManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
