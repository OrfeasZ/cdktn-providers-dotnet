using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors")]
    public class ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors : aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#field ObservabilityadminTelemetryRuleForOrganization#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        public string Field
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#ends_with ObservabilityadminTelemetryRuleForOrganization#ends_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EndsWith
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#equals ObservabilityadminTelemetryRuleForOrganization#equals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "equalTo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EqualTo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#not_ends_with ObservabilityadminTelemetryRuleForOrganization#not_ends_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notEndsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotEndsWith
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#not_equals ObservabilityadminTelemetryRuleForOrganization#not_equals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notEquals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotEquals
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#not_starts_with ObservabilityadminTelemetryRuleForOrganization#not_starts_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notStartsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotStartsWith
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#starts_with ObservabilityadminTelemetryRuleForOrganization#starts_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? StartsWith
        {
            get;
            set;
        }
    }
}
