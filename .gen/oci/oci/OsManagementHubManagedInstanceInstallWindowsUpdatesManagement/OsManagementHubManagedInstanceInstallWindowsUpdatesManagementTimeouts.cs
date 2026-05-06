using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceInstallWindowsUpdatesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceInstallWindowsUpdatesManagement.OsManagementHubManagedInstanceInstallWindowsUpdatesManagementTimeouts")]
    public class OsManagementHubManagedInstanceInstallWindowsUpdatesManagementTimeouts : oci.OsManagementHubManagedInstanceInstallWindowsUpdatesManagement.IOsManagementHubManagedInstanceInstallWindowsUpdatesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_install_windows_updates_management#create OsManagementHubManagedInstanceInstallWindowsUpdatesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_install_windows_updates_management#delete OsManagementHubManagedInstanceInstallWindowsUpdatesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_install_windows_updates_management#update OsManagementHubManagedInstanceInstallWindowsUpdatesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
