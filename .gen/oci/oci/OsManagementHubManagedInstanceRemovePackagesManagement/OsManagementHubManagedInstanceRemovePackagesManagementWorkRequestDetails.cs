using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceRemovePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceRemovePackagesManagement.OsManagementHubManagedInstanceRemovePackagesManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstanceRemovePackagesManagementWorkRequestDetails : oci.OsManagementHubManagedInstanceRemovePackagesManagement.IOsManagementHubManagedInstanceRemovePackagesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_packages_management#description OsManagementHubManagedInstanceRemovePackagesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_packages_management#display_name OsManagementHubManagedInstanceRemovePackagesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
