using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceInstallPackagesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceInstallPackagesManagement.OsManagementHubManagedInstanceInstallPackagesManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstanceInstallPackagesManagementWorkRequestDetails : oci.OsManagementHubManagedInstanceInstallPackagesManagement.IOsManagementHubManagedInstanceInstallPackagesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_managed_instance_install_packages_management#description OsManagementHubManagedInstanceInstallPackagesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_managed_instance_install_packages_management#display_name OsManagementHubManagedInstanceInstallPackagesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
