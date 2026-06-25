using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceInstallPackagesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceInstallPackagesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceInstallPackagesManagement.OsManagementHubManagedInstanceInstallPackagesManagementWorkRequestDetails")]
    public interface IOsManagementHubManagedInstanceInstallPackagesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_install_packages_management#description OsManagementHubManagedInstanceInstallPackagesManagement#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_install_packages_management#display_name OsManagementHubManagedInstanceInstallPackagesManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceInstallPackagesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceInstallPackagesManagement.OsManagementHubManagedInstanceInstallPackagesManagementWorkRequestDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceInstallPackagesManagement.IOsManagementHubManagedInstanceInstallPackagesManagementWorkRequestDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_install_packages_management#description OsManagementHubManagedInstanceInstallPackagesManagement#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_install_packages_management#display_name OsManagementHubManagedInstanceInstallPackagesManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
