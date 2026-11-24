using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementLogger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementLogger.ApiManagementLoggerEventhub")]
    public class ApiManagementLoggerEventhub : azurerm.ApiManagementLogger.IApiManagementLoggerEventhub
    {
        /// <summary>The name of an EventHub.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#name ApiManagementLogger#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The connection string of an EventHub Namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#connection_string ApiManagementLogger#connection_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionString
        {
            get;
            set;
        }

        /// <summary>The endpoint address of an EventHub Namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#endpoint_uri ApiManagementLogger#endpoint_uri}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpointUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointUri
        {
            get;
            set;
        }

        /// <summary>The Client ID of the User Assigned Identity with the "Azure Event Hubs Data Sender" role to the target EventHub Namespace.</summary>
        /// <remarks>
        /// If not specified the System Assigned Identity will be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#user_assigned_identity_client_id ApiManagementLogger#user_assigned_identity_client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAssignedIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAssignedIdentityClientId
        {
            get;
            set;
        }
    }
}
