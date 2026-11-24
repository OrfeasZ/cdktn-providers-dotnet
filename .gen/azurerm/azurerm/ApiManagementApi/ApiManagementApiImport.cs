using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementApi.ApiManagementApiImport")]
    public class ApiManagementApiImport : azurerm.ApiManagementApi.IApiManagementApiImport
    {
        /// <summary>The format of the content from which the API Definition should be imported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#content_format ApiManagementApi#content_format}
        /// </remarks>
        [JsiiProperty(name: "contentFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentFormat
        {
            get;
            set;
        }

        /// <summary>The Content from which the API Definition should be imported.</summary>
        /// <remarks>
        /// When a <c>content_format</c> of <c>*-link-*</c> is specified this must be a URL, otherwise this must be defined inline. The URL must be accessible and return a valid document; otherwise, deployment may fail.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#content_value ApiManagementApi#content_value}
        /// </remarks>
        [JsiiProperty(name: "contentValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentValue
        {
            get;
            set;
        }

        /// <summary>wsdl_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#wsdl_selector ApiManagementApi#wsdl_selector}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wsdlSelector", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImportWsdlSelector\"}", isOptional: true)]
        public azurerm.ApiManagementApi.IApiManagementApiImportWsdlSelector? WsdlSelector
        {
            get;
            set;
        }
    }
}
