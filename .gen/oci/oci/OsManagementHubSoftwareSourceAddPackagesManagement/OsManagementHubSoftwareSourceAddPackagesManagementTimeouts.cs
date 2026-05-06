using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSourceAddPackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubSoftwareSourceAddPackagesManagement.OsManagementHubSoftwareSourceAddPackagesManagementTimeouts")]
    public class OsManagementHubSoftwareSourceAddPackagesManagementTimeouts : oci.OsManagementHubSoftwareSourceAddPackagesManagement.IOsManagementHubSoftwareSourceAddPackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_add_packages_management#create OsManagementHubSoftwareSourceAddPackagesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_add_packages_management#delete OsManagementHubSoftwareSourceAddPackagesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_add_packages_management#update OsManagementHubSoftwareSourceAddPackagesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
