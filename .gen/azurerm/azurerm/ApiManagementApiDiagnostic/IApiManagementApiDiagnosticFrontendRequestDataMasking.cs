using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiDiagnostic
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiDiagnosticFrontendRequestDataMasking), fullyQualifiedName: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendRequestDataMasking")]
    public interface IApiManagementApiDiagnosticFrontendRequestDataMasking
    {
        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/api_management_api_diagnostic#headers ApiManagementApiDiagnostic#headers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendRequestDataMaskingHeaders" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendRequestDataMaskingHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Headers
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/api_management_api_diagnostic#query_params ApiManagementApiDiagnostic#query_params}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendRequestDataMaskingQueryParams" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "queryParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendRequestDataMaskingQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryParams
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiDiagnosticFrontendRequestDataMasking), fullyQualifiedName: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendRequestDataMasking")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendRequestDataMasking
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/api_management_api_diagnostic#headers ApiManagementApiDiagnostic#headers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendRequestDataMaskingHeaders" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendRequestDataMaskingHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Headers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_params block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/api_management_api_diagnostic#query_params ApiManagementApiDiagnostic#query_params}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendRequestDataMaskingQueryParams" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendRequestDataMaskingQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryParams
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
