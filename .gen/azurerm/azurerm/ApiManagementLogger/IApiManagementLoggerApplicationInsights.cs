using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementLogger
{
    [JsiiInterface(nativeType: typeof(IApiManagementLoggerApplicationInsights), fullyQualifiedName: "azurerm.apiManagementLogger.ApiManagementLoggerApplicationInsights")]
    public interface IApiManagementLoggerApplicationInsights
    {
        /// <summary>The connection string of Application Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#connection_string ApiManagementLogger#connection_string}
        /// </remarks>
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Client ID of the User Assigned Identity, or `SystemAssigned` to use the System Assigned Identity, that has the "Monitoring Metrics Publisher" role on the target Application Insights resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#identity_client_id ApiManagementLogger#identity_client_id}
        /// </remarks>
        [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The instrumentation key used to push data to Application Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#instrumentation_key ApiManagementLogger#instrumentation_key}
        /// </remarks>
        [JsiiProperty(name: "instrumentationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstrumentationKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementLoggerApplicationInsights), fullyQualifiedName: "azurerm.apiManagementLogger.ApiManagementLoggerApplicationInsights")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementLogger.IApiManagementLoggerApplicationInsights
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The connection string of Application Insights.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#connection_string ApiManagementLogger#connection_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Client ID of the User Assigned Identity, or `SystemAssigned` to use the System Assigned Identity, that has the "Monitoring Metrics Publisher" role on the target Application Insights resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#identity_client_id ApiManagementLogger#identity_client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The instrumentation key used to push data to Application Insights.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_logger#instrumentation_key ApiManagementLogger#instrumentation_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instrumentationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstrumentationKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
