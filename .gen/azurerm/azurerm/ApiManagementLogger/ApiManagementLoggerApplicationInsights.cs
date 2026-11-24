using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementLogger
{
    [JsiiByValue(fqn: "azurerm.apiManagementLogger.ApiManagementLoggerApplicationInsights")]
    public class ApiManagementLoggerApplicationInsights : azurerm.ApiManagementLogger.IApiManagementLoggerApplicationInsights
    {
        /// <summary>The connection string of Application Insights.</summary>
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

        /// <summary>The Client ID of the User Assigned Identity, or `SystemAssigned` to use the System Assigned Identity, that has the "Monitoring Metrics Publisher" role on the target Application Insights resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#identity_client_id ApiManagementLogger#identity_client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityClientId
        {
            get;
            set;
        }

        /// <summary>The instrumentation key used to push data to Application Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#instrumentation_key ApiManagementLogger#instrumentation_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instrumentationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstrumentationKey
        {
            get;
            set;
        }
    }
}
