using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementLogger
{
    [JsiiByValue(fqn: "azurerm.apiManagementLogger.ApiManagementLoggerApplicationInsights")]
    public class ApiManagementLoggerApplicationInsights : azurerm.ApiManagementLogger.IApiManagementLoggerApplicationInsights
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/api_management_logger#connection_string ApiManagementLogger#connection_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/api_management_logger#identity_client_id ApiManagementLogger#identity_client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/api_management_logger#instrumentation_key ApiManagementLogger#instrumentation_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instrumentationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstrumentationKey
        {
            get;
            set;
        }
    }
}
