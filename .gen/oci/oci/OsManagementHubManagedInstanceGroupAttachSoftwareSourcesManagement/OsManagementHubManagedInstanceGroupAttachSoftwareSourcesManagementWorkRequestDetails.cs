using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagementWorkRequestDetails : oci.OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_attach_software_sources_management#description OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_attach_software_sources_management#display_name OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
