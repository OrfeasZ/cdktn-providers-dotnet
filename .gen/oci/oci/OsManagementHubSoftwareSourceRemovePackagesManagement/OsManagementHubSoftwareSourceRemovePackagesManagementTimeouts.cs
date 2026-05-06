using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSourceRemovePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubSoftwareSourceRemovePackagesManagement.OsManagementHubSoftwareSourceRemovePackagesManagementTimeouts")]
    public class OsManagementHubSoftwareSourceRemovePackagesManagementTimeouts : oci.OsManagementHubSoftwareSourceRemovePackagesManagement.IOsManagementHubSoftwareSourceRemovePackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_remove_packages_management#create OsManagementHubSoftwareSourceRemovePackagesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_remove_packages_management#delete OsManagementHubSoftwareSourceRemovePackagesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_remove_packages_management#update OsManagementHubSoftwareSourceRemovePackagesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
