using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails : oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management#description OsManagementHubManagedInstanceDetachSoftwareSourcesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management#display_name OsManagementHubManagedInstanceDetachSoftwareSourcesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
