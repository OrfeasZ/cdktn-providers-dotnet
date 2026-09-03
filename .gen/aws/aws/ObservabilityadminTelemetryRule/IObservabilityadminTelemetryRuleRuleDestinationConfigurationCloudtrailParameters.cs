using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRule
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParameters), fullyQualifiedName: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParameters")]
    public interface IObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParameters
    {
        /// <summary>advanced_event_selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#advanced_event_selectors ObservabilityadminTelemetryRule#advanced_event_selectors}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectors" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "advancedEventSelectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdvancedEventSelectors
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParameters), fullyQualifiedName: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParameters")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>advanced_event_selectors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#advanced_event_selectors ObservabilityadminTelemetryRule#advanced_event_selectors}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectors" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "advancedEventSelectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdvancedEventSelectors
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
