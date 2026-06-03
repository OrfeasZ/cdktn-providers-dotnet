using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    [JsiiByValue(fqn: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationElbLoadBalancerLoggingParameters")]
    public class ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationElbLoadBalancerLoggingParameters : aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationElbLoadBalancerLoggingParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.48.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#field_delimiter ObservabilityadminTelemetryRuleForOrganization#field_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FieldDelimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.48.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#output_format ObservabilityadminTelemetryRuleForOrganization#output_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputFormat
        {
            get;
            set;
        }
    }
}
