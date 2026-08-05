using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstancesInstallWindowsUpdatesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstancesInstallWindowsUpdatesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstancesInstallWindowsUpdatesManagement.OsManagementHubManagedInstancesInstallWindowsUpdatesManagementTimeouts")]
    public interface IOsManagementHubManagedInstancesInstallWindowsUpdatesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#create OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#delete OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#update OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstancesInstallWindowsUpdatesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstancesInstallWindowsUpdatesManagement.OsManagementHubManagedInstancesInstallWindowsUpdatesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstancesInstallWindowsUpdatesManagement.IOsManagementHubManagedInstancesInstallWindowsUpdatesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#create OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#delete OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instances_install_windows_updates_management#update OsManagementHubManagedInstancesInstallWindowsUpdatesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
