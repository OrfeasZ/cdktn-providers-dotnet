using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetRemovePackagesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubDynamicSetRemovePackagesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubDynamicSetRemovePackagesManagement.OsManagementHubDynamicSetRemovePackagesManagementTimeouts")]
    public interface IOsManagementHubDynamicSetRemovePackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/os_management_hub_dynamic_set_remove_packages_management#create OsManagementHubDynamicSetRemovePackagesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/os_management_hub_dynamic_set_remove_packages_management#delete OsManagementHubDynamicSetRemovePackagesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/os_management_hub_dynamic_set_remove_packages_management#update OsManagementHubDynamicSetRemovePackagesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubDynamicSetRemovePackagesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubDynamicSetRemovePackagesManagement.OsManagementHubDynamicSetRemovePackagesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubDynamicSetRemovePackagesManagement.IOsManagementHubDynamicSetRemovePackagesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/os_management_hub_dynamic_set_remove_packages_management#create OsManagementHubDynamicSetRemovePackagesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/os_management_hub_dynamic_set_remove_packages_management#delete OsManagementHubDynamicSetRemovePackagesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/os_management_hub_dynamic_set_remove_packages_management#update OsManagementHubDynamicSetRemovePackagesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
