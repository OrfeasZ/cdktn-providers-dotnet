using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRule
{
    [JsiiByValue(fqn: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParameters")]
    public class ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParameters : aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParameters
    {
        private object? _loggingFilter;

        /// <summary>logging_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#logging_filter ObservabilityadminTelemetryRule#logging_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loggingFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LoggingFilter
        {
            get => _loggingFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _loggingFilter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#log_type ObservabilityadminTelemetryRule#log_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogType
        {
            get;
            set;
        }

        private object? _redactedFields;

        /// <summary>redacted_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#redacted_fields ObservabilityadminTelemetryRule#redacted_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redactedFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RedactedFields
        {
            get => _redactedFields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redactedFields = value;
            }
        }
    }
}
