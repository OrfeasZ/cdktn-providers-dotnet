using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiInterface(nativeType: typeof(IApiManagementBackendCircuitBreakerRule), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRule")]
    public interface IApiManagementBackendCircuitBreakerRule
    {
        /// <summary>failure_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/api_management_backend#failure_condition ApiManagementBackend#failure_condition}
        /// </remarks>
        [JsiiProperty(name: "failureCondition", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureCondition\"}")]
        azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureCondition FailureCondition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/api_management_backend#name ApiManagementBackend#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/api_management_backend#trip_duration ApiManagementBackend#trip_duration}.</summary>
        [JsiiProperty(name: "tripDuration", typeJson: "{\"primitive\":\"string\"}")]
        string TripDuration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/api_management_backend#accept_retry_after_enabled ApiManagementBackend#accept_retry_after_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "acceptRetryAfterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AcceptRetryAfterEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementBackendCircuitBreakerRule), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>failure_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/api_management_backend#failure_condition ApiManagementBackend#failure_condition}
            /// </remarks>
            [JsiiProperty(name: "failureCondition", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureCondition\"}")]
            public azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureCondition FailureCondition
            {
                get => GetInstanceProperty<azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureCondition>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/api_management_backend#name ApiManagementBackend#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/api_management_backend#trip_duration ApiManagementBackend#trip_duration}.</summary>
            [JsiiProperty(name: "tripDuration", typeJson: "{\"primitive\":\"string\"}")]
            public string TripDuration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/api_management_backend#accept_retry_after_enabled ApiManagementBackend#accept_retry_after_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceptRetryAfterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AcceptRetryAfterEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
