using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiDiagnostic
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiDiagnosticFrontendResponseDataMasking), fullyQualifiedName: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendResponseDataMasking")]
    public interface IApiManagementApiDiagnosticFrontendResponseDataMasking
    {
        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/api_management_api_diagnostic#headers ApiManagementApiDiagnostic#headers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendResponseDataMaskingHeaders" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendResponseDataMaskingHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/api_management_api_diagnostic#query_params ApiManagementApiDiagnostic#query_params}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendResponseDataMaskingQueryParams" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "queryParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendResponseDataMaskingQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryParams
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiDiagnosticFrontendResponseDataMasking), fullyQualifiedName: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendResponseDataMasking")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendResponseDataMasking
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/api_management_api_diagnostic#headers ApiManagementApiDiagnostic#headers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendResponseDataMaskingHeaders" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendResponseDataMaskingHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Headers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_params block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/api_management_api_diagnostic#query_params ApiManagementApiDiagnostic#query_params}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendResponseDataMaskingQueryParams" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendResponseDataMaskingQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryParams
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
