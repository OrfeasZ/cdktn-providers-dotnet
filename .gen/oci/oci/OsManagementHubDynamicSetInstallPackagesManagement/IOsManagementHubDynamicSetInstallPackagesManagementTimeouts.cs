using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetInstallPackagesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubDynamicSetInstallPackagesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementTimeouts")]
    public interface IOsManagementHubDynamicSetInstallPackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#create OsManagementHubDynamicSetInstallPackagesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#delete OsManagementHubDynamicSetInstallPackagesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#update OsManagementHubDynamicSetInstallPackagesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubDynamicSetInstallPackagesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubDynamicSetInstallPackagesManagement.OsManagementHubDynamicSetInstallPackagesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubDynamicSetInstallPackagesManagement.IOsManagementHubDynamicSetInstallPackagesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#create OsManagementHubDynamicSetInstallPackagesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#delete OsManagementHubDynamicSetInstallPackagesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set_install_packages_management#update OsManagementHubDynamicSetInstallPackagesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
