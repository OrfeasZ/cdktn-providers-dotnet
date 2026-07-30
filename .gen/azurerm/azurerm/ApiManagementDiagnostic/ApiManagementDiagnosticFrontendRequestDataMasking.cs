using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementDiagnostic
{
    [JsiiByValue(fqn: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendRequestDataMasking")]
    public class ApiManagementDiagnosticFrontendRequestDataMasking : azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequestDataMasking
    {
        private object? _headers;

        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/api_management_diagnostic#headers ApiManagementDiagnostic#headers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequestDataMaskingHeaders" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendRequestDataMaskingHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequestDataMaskingHeaders[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequestDataMaskingHeaders).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _headers = value;
            }
        }

        private object? _queryParams;

        /// <summary>query_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/api_management_diagnostic#query_params ApiManagementDiagnostic#query_params}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequestDataMaskingQueryParams" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendRequestDataMaskingQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequestDataMaskingQueryParams[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequestDataMaskingQueryParams).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queryParams = value;
            }
        }
    }
}
