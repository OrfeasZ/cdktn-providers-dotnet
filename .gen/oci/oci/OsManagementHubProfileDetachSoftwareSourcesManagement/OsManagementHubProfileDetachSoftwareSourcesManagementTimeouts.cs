using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubProfileDetachSoftwareSourcesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubProfileDetachSoftwareSourcesManagement.OsManagementHubProfileDetachSoftwareSourcesManagementTimeouts")]
    public class OsManagementHubProfileDetachSoftwareSourcesManagementTimeouts : oci.OsManagementHubProfileDetachSoftwareSourcesManagement.IOsManagementHubProfileDetachSoftwareSourcesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_detach_software_sources_management#create OsManagementHubProfileDetachSoftwareSourcesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_detach_software_sources_management#delete OsManagementHubProfileDetachSoftwareSourcesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_detach_software_sources_management#update OsManagementHubProfileDetachSoftwareSourcesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
