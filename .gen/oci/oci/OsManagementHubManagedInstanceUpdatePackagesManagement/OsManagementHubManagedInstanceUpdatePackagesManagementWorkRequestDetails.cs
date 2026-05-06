using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceUpdatePackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceUpdatePackagesManagement.OsManagementHubManagedInstanceUpdatePackagesManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstanceUpdatePackagesManagementWorkRequestDetails : oci.OsManagementHubManagedInstanceUpdatePackagesManagement.IOsManagementHubManagedInstanceUpdatePackagesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_update_packages_management#description OsManagementHubManagedInstanceUpdatePackagesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_update_packages_management#display_name OsManagementHubManagedInstanceUpdatePackagesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
