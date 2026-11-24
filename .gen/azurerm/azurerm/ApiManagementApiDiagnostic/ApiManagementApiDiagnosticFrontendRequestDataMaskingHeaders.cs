using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiDiagnostic
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendRequestDataMaskingHeaders")]
    public class ApiManagementApiDiagnosticFrontendRequestDataMaskingHeaders : azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendRequestDataMaskingHeaders
    {
        /// <summary>The data masking mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#mode ApiManagementApiDiagnostic#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>The name of the header or the query parameter to mask.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#value ApiManagementApiDiagnostic#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
