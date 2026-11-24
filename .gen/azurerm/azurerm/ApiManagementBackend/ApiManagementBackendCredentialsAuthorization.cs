using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiByValue(fqn: "azurerm.apiManagementBackend.ApiManagementBackendCredentialsAuthorization")]
    public class ApiManagementBackendCredentialsAuthorization : azurerm.ApiManagementBackend.IApiManagementBackendCredentialsAuthorization
    {
        /// <summary>The authentication Parameter value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#parameter ApiManagementBackend#parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Parameter
        {
            get;
            set;
        }

        /// <summary>The authentication Scheme name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#scheme ApiManagementBackend#scheme}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scheme
        {
            get;
            set;
        }
    }
}
