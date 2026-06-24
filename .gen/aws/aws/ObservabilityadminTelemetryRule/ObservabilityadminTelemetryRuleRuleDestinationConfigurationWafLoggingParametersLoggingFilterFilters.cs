using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRule
{
    [JsiiByValue(fqn: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters")]
    public class ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters : aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#behavior ObservabilityadminTelemetryRule#behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Behavior
        {
            get;
            set;
        }

        private object? _conditions;

        /// <summary>conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#conditions ObservabilityadminTelemetryRule#conditions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Conditions
        {
            get => _conditions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#requirement ObservabilityadminTelemetryRule#requirement}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requirement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Requirement
        {
            get;
            set;
        }
    }
}
