using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiSubscriptionKeyParameterNames), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiSubscriptionKeyParameterNames")]
    public interface IApiManagementApiSubscriptionKeyParameterNames
    {
        /// <summary>The name of the HTTP Header which should be used for the Subscription Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#header ApiManagementApi#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"primitive\":\"string\"}")]
        string Header
        {
            get;
        }

        /// <summary>The name of the QueryString parameter which should be used for the Subscription Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#query ApiManagementApi#query}
        /// </remarks>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        string Query
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiSubscriptionKeyParameterNames), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiSubscriptionKeyParameterNames")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApi.IApiManagementApiSubscriptionKeyParameterNames
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the HTTP Header which should be used for the Subscription Key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#header ApiManagementApi#header}
            /// </remarks>
            [JsiiProperty(name: "header", typeJson: "{\"primitive\":\"string\"}")]
            public string Header
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the QueryString parameter which should be used for the Subscription Key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#query ApiManagementApi#query}
            /// </remarks>
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
            public string Query
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
