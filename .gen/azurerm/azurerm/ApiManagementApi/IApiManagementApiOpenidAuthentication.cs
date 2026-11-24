using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiOpenidAuthentication), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiOpenidAuthentication")]
    public interface IApiManagementApiOpenidAuthentication
    {
        /// <summary>OpenID Connect provider identifier. The name of an [OpenID Connect Provider](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/api_management_openid_connect_provider).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#openid_provider_name ApiManagementApi#openid_provider_name}
        /// </remarks>
        [JsiiProperty(name: "openidProviderName", typeJson: "{\"primitive\":\"string\"}")]
        string OpenidProviderName
        {
            get;
        }

        /// <summary>How to send token to the server. A list of zero or more methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#bearer_token_sending_methods ApiManagementApi#bearer_token_sending_methods}
        /// </remarks>
        [JsiiProperty(name: "bearerTokenSendingMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BearerTokenSendingMethods
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiOpenidAuthentication), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiOpenidAuthentication")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApi.IApiManagementApiOpenidAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>OpenID Connect provider identifier. The name of an [OpenID Connect Provider](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/api_management_openid_connect_provider).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#openid_provider_name ApiManagementApi#openid_provider_name}
            /// </remarks>
            [JsiiProperty(name: "openidProviderName", typeJson: "{\"primitive\":\"string\"}")]
            public string OpenidProviderName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>How to send token to the server. A list of zero or more methods.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#bearer_token_sending_methods ApiManagementApi#bearer_token_sending_methods}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bearerTokenSendingMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BearerTokenSendingMethods
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
