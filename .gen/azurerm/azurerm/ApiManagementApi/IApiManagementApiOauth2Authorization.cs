using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiOauth2Authorization), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiOauth2Authorization")]
    public interface IApiManagementApiOauth2Authorization
    {
        /// <summary>OAuth authorization server identifier. The name of an [OAuth2 Authorization Server](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/api_management_authorization_server).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#authorization_server_name ApiManagementApi#authorization_server_name}
        /// </remarks>
        [JsiiProperty(name: "authorizationServerName", typeJson: "{\"primitive\":\"string\"}")]
        string AuthorizationServerName
        {
            get;
        }

        /// <summary>Operations scope.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#scope ApiManagementApi#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scope
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiOauth2Authorization), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiOauth2Authorization")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApi.IApiManagementApiOauth2Authorization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>OAuth authorization server identifier. The name of an [OAuth2 Authorization Server](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/api_management_authorization_server).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#authorization_server_name ApiManagementApi#authorization_server_name}
            /// </remarks>
            [JsiiProperty(name: "authorizationServerName", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthorizationServerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Operations scope.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#scope ApiManagementApi#scope}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
