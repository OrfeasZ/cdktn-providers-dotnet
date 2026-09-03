using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRule
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters), fullyQualifiedName: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters")]
    public interface IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#behavior ObservabilityadminTelemetryRule#behavior}.</summary>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Behavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#conditions ObservabilityadminTelemetryRule#conditions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Conditions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#requirement ObservabilityadminTelemetryRule#requirement}.</summary>
        [JsiiProperty(name: "requirement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Requirement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters), fullyQualifiedName: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#behavior ObservabilityadminTelemetryRule#behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Behavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>conditions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#conditions ObservabilityadminTelemetryRule#conditions}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Conditions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#requirement ObservabilityadminTelemetryRule#requirement}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requirement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Requirement
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
