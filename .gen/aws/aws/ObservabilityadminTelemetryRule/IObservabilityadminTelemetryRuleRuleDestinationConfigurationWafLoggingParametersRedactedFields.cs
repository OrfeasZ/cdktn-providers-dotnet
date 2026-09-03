using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRule
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFields), fullyQualifiedName: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFields")]
    public interface IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#method ObservabilityadminTelemetryRule#method}.</summary>
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#query_string ObservabilityadminTelemetryRule#query_string}.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#single_header ObservabilityadminTelemetryRule#single_header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFieldsSingleHeader" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "singleHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFieldsSingleHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SingleHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#uri_path ObservabilityadminTelemetryRule#uri_path}.</summary>
        [JsiiProperty(name: "uriPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFields), fullyQualifiedName: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFields")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#method ObservabilityadminTelemetryRule#method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Method
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#query_string ObservabilityadminTelemetryRule#query_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>single_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#single_header ObservabilityadminTelemetryRule#single_header}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFieldsSingleHeader" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParametersRedactedFieldsSingleHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SingleHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule#uri_path ObservabilityadminTelemetryRule#uri_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UriPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
