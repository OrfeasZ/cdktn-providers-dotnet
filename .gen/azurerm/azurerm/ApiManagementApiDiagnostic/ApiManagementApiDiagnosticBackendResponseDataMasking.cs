using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiDiagnostic
{
    [JsiiByValue(fqn: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseDataMasking")]
    public class ApiManagementApiDiagnosticBackendResponseDataMasking : azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMasking
    {
        private object? _headers;

        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/api_management_api_diagnostic#headers ApiManagementApiDiagnostic#headers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMaskingHeaders" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseDataMaskingHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Headers
        {
            get => _headers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMaskingHeaders[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMaskingHeaders).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _headers = value;
            }
        }

        private object? _queryParams;

        /// <summary>query_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/api_management_api_diagnostic#query_params ApiManagementApiDiagnostic#query_params}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMaskingQueryParams" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseDataMaskingQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QueryParams
        {
            get => _queryParams;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMaskingQueryParams[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMaskingQueryParams).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queryParams = value;
            }
        }
    }
}
