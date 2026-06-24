using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors")]
    public class ObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors : aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#field ObservabilityadminTelemetryRule#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        public string Field
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#ends_with ObservabilityadminTelemetryRule#ends_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EndsWith
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#equals ObservabilityadminTelemetryRule#equals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "equalTo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EqualTo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#not_ends_with ObservabilityadminTelemetryRule#not_ends_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notEndsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotEndsWith
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#not_equals ObservabilityadminTelemetryRule#not_equals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notEquals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotEquals
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#not_starts_with ObservabilityadminTelemetryRule#not_starts_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notStartsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotStartsWith
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule#starts_with ObservabilityadminTelemetryRule#starts_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? StartsWith
        {
            get;
            set;
        }
    }
}
