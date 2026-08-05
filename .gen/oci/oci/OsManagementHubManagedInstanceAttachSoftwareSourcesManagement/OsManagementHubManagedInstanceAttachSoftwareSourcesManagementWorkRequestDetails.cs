using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetails : oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#description OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#display_name OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
