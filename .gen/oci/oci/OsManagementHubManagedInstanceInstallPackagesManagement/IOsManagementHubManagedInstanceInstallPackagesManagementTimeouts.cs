using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceInstallPackagesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceInstallPackagesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceInstallPackagesManagement.OsManagementHubManagedInstanceInstallPackagesManagementTimeouts")]
    public interface IOsManagementHubManagedInstanceInstallPackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_packages_management#create OsManagementHubManagedInstanceInstallPackagesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_packages_management#delete OsManagementHubManagedInstanceInstallPackagesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_packages_management#update OsManagementHubManagedInstanceInstallPackagesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceInstallPackagesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceInstallPackagesManagement.OsManagementHubManagedInstanceInstallPackagesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceInstallPackagesManagement.IOsManagementHubManagedInstanceInstallPackagesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_packages_management#create OsManagementHubManagedInstanceInstallPackagesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_packages_management#delete OsManagementHubManagedInstanceInstallPackagesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_packages_management#update OsManagementHubManagedInstanceInstallPackagesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
