using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts")]
    public class OsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts : oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#create OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#delete OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#update OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
