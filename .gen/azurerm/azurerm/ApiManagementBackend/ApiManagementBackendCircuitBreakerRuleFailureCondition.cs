using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureCondition")]
    public class ApiManagementBackendCircuitBreakerRuleFailureCondition : azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureCondition
    {
        /// <summary>The time window over which failures are counted, in ISO 8601 format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#interval_duration ApiManagementBackend#interval_duration}
        /// </remarks>
        [JsiiProperty(name: "intervalDuration", typeJson: "{\"primitive\":\"string\"}")]
        public string IntervalDuration
        {
            get;
            set;
        }

        /// <summary>The number of failures within the specified interval that will trigger the circuit breaker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#count ApiManagementBackend#count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <summary>A list of error reasons to consider as failures.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#error_reasons ApiManagementBackend#error_reasons}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "errorReasons", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ErrorReasons
        {
            get;
            set;
        }

        /// <summary>The percentage of failures within the specified interval that will trigger the circuit breaker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#percentage ApiManagementBackend#percentage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Percentage
        {
            get;
            set;
        }

        private object? _statusCodeRange;

        /// <summary>status_code_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#status_code_range ApiManagementBackend#status_code_range}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCodeRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StatusCodeRange
        {
            get => _statusCodeRange;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _statusCodeRange = value;
            }
        }
    }
}
