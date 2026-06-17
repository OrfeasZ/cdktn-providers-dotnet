using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParameters), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParameters")]
    public interface IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParameters
    {
        /// <summary>logging_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#logging_filter ObservabilityadminTelemetryRuleForOrganization#logging_filter}
        /// </remarks>
        [JsiiProperty(name: "loggingFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LoggingFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#log_type ObservabilityadminTelemetryRuleForOrganization#log_type}.</summary>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogType
        {
            get
            {
                return null;
            }
        }

        /// <summary>redacted_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#redacted_fields ObservabilityadminTelemetryRuleForOrganization#redacted_fields}
        /// </remarks>
        [JsiiProperty(name: "redactedFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersRedactedFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RedactedFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParameters), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParameters")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>logging_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#logging_filter ObservabilityadminTelemetryRuleForOrganization#logging_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loggingFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LoggingFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#log_type ObservabilityadminTelemetryRuleForOrganization#log_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>redacted_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#redacted_fields ObservabilityadminTelemetryRuleForOrganization#redacted_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redactedFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersRedactedFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RedactedFields
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
