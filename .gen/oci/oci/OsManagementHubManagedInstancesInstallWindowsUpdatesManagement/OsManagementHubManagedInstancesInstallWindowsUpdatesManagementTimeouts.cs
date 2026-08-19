using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstancesInstallWindowsUpdatesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstancesInstallWindowsUpdatesManagement.OsManagementHubManagedInstancesInstallWindowsUpdatesManagementTimeouts")]
    public class OsManagementHubManagedInstancesInstallWindowsUpdatesManagementTimeouts : oci.OsManagementHubManagedInstancesInstallWindowsUpdatesManagement.IOsManagementHubManagedInstancesInstallWindowsUpdatesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#create OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#delete OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#update OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
