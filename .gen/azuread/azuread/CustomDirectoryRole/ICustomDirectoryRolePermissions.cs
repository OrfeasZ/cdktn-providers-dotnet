using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.CustomDirectoryRole
{
    [JsiiInterface(nativeType: typeof(ICustomDirectoryRolePermissions), fullyQualifiedName: "azuread.customDirectoryRole.CustomDirectoryRolePermissions")]
    public interface ICustomDirectoryRolePermissions
    {
        /// <summary>Set of tasks that can be performed on a resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/custom_directory_role#allowed_resource_actions CustomDirectoryRole#allowed_resource_actions}
        /// </remarks>
        [JsiiProperty(name: "allowedResourceActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedResourceActions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomDirectoryRolePermissions), fullyQualifiedName: "azuread.customDirectoryRole.CustomDirectoryRolePermissions")]
        internal sealed class _Proxy : DeputyBase, azuread.CustomDirectoryRole.ICustomDirectoryRolePermissions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Set of tasks that can be performed on a resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/custom_directory_role#allowed_resource_actions CustomDirectoryRole#allowed_resource_actions}
            /// </remarks>
            [JsiiProperty(name: "allowedResourceActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedResourceActions
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
