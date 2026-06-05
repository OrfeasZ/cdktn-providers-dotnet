using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilter), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilter")]
    public interface IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.49.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#default_behavior ObservabilityadminTelemetryRuleForOrganization#default_behavior}.</summary>
        [JsiiProperty(name: "defaultBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.49.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#filters ObservabilityadminTelemetryRuleForOrganization#filters}
        /// </remarks>
        [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilter), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilter")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.49.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#default_behavior ObservabilityadminTelemetryRuleForOrganization#default_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.49.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#filters ObservabilityadminTelemetryRuleForOrganization#filters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilterFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filters
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
