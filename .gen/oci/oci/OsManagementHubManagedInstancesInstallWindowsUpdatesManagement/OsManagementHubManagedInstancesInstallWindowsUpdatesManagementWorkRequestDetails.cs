using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstancesInstallWindowsUpdatesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstancesInstallWindowsUpdatesManagement.OsManagementHubManagedInstancesInstallWindowsUpdatesManagementWorkRequestDetails")]
    public class OsManagementHubManagedInstancesInstallWindowsUpdatesManagementWorkRequestDetails : oci.OsManagementHubManagedInstancesInstallWindowsUpdatesManagement.IOsManagementHubManagedInstancesInstallWindowsUpdatesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#description OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#display_name OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
