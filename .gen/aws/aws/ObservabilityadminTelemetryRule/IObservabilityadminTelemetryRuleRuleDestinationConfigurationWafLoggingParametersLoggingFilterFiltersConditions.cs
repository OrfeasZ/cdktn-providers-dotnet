using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRule
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions), fullyQualifiedName: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions")]
    public interface IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions
    {
        /// <summary>action_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#action_condition ObservabilityadminTelemetryRule#action_condition}
        /// </remarks>
        [JsiiProperty(name: "actionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditionsActionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ActionCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>label_name_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#label_name_condition ObservabilityadminTelemetryRule#label_name_condition}
        /// </remarks>
        [JsiiProperty(name: "labelNameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditionsLabelNameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LabelNameCondition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions), fullyQualifiedName: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#action_condition ObservabilityadminTelemetryRule#action_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "actionCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditionsActionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ActionCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>label_name_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#label_name_condition ObservabilityadminTelemetryRule#label_name_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "labelNameCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditionsLabelNameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LabelNameCondition
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
