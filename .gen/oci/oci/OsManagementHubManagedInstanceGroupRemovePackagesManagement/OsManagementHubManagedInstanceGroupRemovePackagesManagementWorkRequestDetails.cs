using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupRemovePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceGroupRemovePackagesManagement.OsManagementHubManagedInstanceGroupRemovePackagesManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstanceGroupRemovePackagesManagementWorkRequestDetails : oci.OsManagementHubManagedInstanceGroupRemovePackagesManagement.IOsManagementHubManagedInstanceGroupRemovePackagesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_remove_packages_management#description OsManagementHubManagedInstanceGroupRemovePackagesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_remove_packages_management#display_name OsManagementHubManagedInstanceGroupRemovePackagesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
