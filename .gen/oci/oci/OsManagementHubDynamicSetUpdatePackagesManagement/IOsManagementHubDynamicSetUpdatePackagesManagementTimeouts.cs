using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetUpdatePackagesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubDynamicSetUpdatePackagesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubDynamicSetUpdatePackagesManagement.OsManagementHubDynamicSetUpdatePackagesManagementTimeouts")]
    public interface IOsManagementHubDynamicSetUpdatePackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#create OsManagementHubDynamicSetUpdatePackagesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#delete OsManagementHubDynamicSetUpdatePackagesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#update OsManagementHubDynamicSetUpdatePackagesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubDynamicSetUpdatePackagesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubDynamicSetUpdatePackagesManagement.OsManagementHubDynamicSetUpdatePackagesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubDynamicSetUpdatePackagesManagement.IOsManagementHubDynamicSetUpdatePackagesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#create OsManagementHubDynamicSetUpdatePackagesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#delete OsManagementHubDynamicSetUpdatePackagesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_dynamic_set_update_packages_management#update OsManagementHubDynamicSetUpdatePackagesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
