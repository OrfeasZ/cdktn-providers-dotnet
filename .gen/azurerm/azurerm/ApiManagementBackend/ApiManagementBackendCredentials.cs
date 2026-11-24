using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiByValue(fqn: "azurerm.apiManagementBackend.ApiManagementBackendCredentials")]
    public class ApiManagementBackendCredentials : azurerm.ApiManagementBackend.IApiManagementBackendCredentials
    {
        /// <summary>authorization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#authorization ApiManagementBackend#authorization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCredentialsAuthorization\"}", isOptional: true)]
        public azurerm.ApiManagementBackend.IApiManagementBackendCredentialsAuthorization? Authorization
        {
            get;
            set;
        }

        /// <summary>A list of client certificate thumbprints to present to the backend host.</summary>
        /// <remarks>
        /// The certificates must exist within the API Management Service.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#certificate ApiManagementBackend#certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Certificate
        {
            get;
            set;
        }

        /// <summary>A mapping of header parameters to pass to the backend host.</summary>
        /// <remarks>
        /// The keys are the header names and the values are a comma separated string of header values. This is converted to a list before being passed to the API.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#header ApiManagementBackend#header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Header
        {
            get;
            set;
        }

        /// <summary>A mapping of query parameters to pass to the backend host.</summary>
        /// <remarks>
        /// The keys are the query names and the values are a comma separated string of query values. This is converted to a list before being passed to the API.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#query ApiManagementBackend#query}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Query
        {
            get;
            set;
        }
    }
}
