using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    [JsiiByValue(fqn: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationLogDeliveryParameters")]
    public class ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationLogDeliveryParameters : aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationLogDeliveryParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#log_types ObservabilityadminTelemetryRuleForOrganization#log_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? LogTypes
        {
            get;
            set;
        }
    }
}
