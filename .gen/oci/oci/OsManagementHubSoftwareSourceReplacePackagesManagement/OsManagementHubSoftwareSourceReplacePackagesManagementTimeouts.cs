using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSourceReplacePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubSoftwareSourceReplacePackagesManagement.OsManagementHubSoftwareSourceReplacePackagesManagementTimeouts")]
    public class OsManagementHubSoftwareSourceReplacePackagesManagementTimeouts : oci.OsManagementHubSoftwareSourceReplacePackagesManagement.IOsManagementHubSoftwareSourceReplacePackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_replace_packages_management#create OsManagementHubSoftwareSourceReplacePackagesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_replace_packages_management#delete OsManagementHubSoftwareSourceReplacePackagesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_replace_packages_management#update OsManagementHubSoftwareSourceReplacePackagesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
