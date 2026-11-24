using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiInterface(nativeType: typeof(IApiManagementBackendCircuitBreakerRuleFailureCondition), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureCondition")]
    public interface IApiManagementBackendCircuitBreakerRuleFailureCondition
    {
        /// <summary>The time window over which failures are counted, in ISO 8601 format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#interval_duration ApiManagementBackend#interval_duration}
        /// </remarks>
        [JsiiProperty(name: "intervalDuration", typeJson: "{\"primitive\":\"string\"}")]
        string IntervalDuration
        {
            get;
        }

        /// <summary>The number of failures within the specified interval that will trigger the circuit breaker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#count ApiManagementBackend#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Count
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of error reasons to consider as failures.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#error_reasons ApiManagementBackend#error_reasons}
        /// </remarks>
        [JsiiProperty(name: "errorReasons", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ErrorReasons
        {
            get
            {
                return null;
            }
        }

        /// <summary>The percentage of failures within the specified interval that will trigger the circuit breaker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#percentage ApiManagementBackend#percentage}
        /// </remarks>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Percentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>status_code_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#status_code_range ApiManagementBackend#status_code_range}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "statusCodeRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StatusCodeRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementBackendCircuitBreakerRuleFailureCondition), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureCondition")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The time window over which failures are counted, in ISO 8601 format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#interval_duration ApiManagementBackend#interval_duration}
            /// </remarks>
            [JsiiProperty(name: "intervalDuration", typeJson: "{\"primitive\":\"string\"}")]
            public string IntervalDuration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The number of failures within the specified interval that will trigger the circuit breaker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#count ApiManagementBackend#count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A list of error reasons to consider as failures.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#error_reasons ApiManagementBackend#error_reasons}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "errorReasons", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ErrorReasons
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The percentage of failures within the specified interval that will trigger the circuit breaker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#percentage ApiManagementBackend#percentage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Percentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>status_code_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#status_code_range ApiManagementBackend#status_code_range}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusCodeRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StatusCodeRange
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
