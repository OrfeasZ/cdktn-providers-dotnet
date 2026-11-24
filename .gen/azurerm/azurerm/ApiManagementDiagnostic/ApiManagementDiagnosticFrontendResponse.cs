using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementDiagnostic
{
    [JsiiByValue(fqn: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendResponse")]
    public class ApiManagementDiagnosticFrontendResponse : azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponse
    {
        /// <summary>Number of payload bytes to log (up to 8192).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_diagnostic#body_bytes ApiManagementDiagnostic#body_bytes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bodyBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BodyBytes
        {
            get;
            set;
        }

        /// <summary>data_masking block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_diagnostic#data_masking ApiManagementDiagnostic#data_masking}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataMasking", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseDataMasking\"}", isOptional: true)]
        public azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponseDataMasking? DataMasking
        {
            get;
            set;
        }

        /// <summary>A list of headers to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_diagnostic#headers_to_log ApiManagementDiagnostic#headers_to_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headersToLog", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HeadersToLog
        {
            get;
            set;
        }
    }
}
