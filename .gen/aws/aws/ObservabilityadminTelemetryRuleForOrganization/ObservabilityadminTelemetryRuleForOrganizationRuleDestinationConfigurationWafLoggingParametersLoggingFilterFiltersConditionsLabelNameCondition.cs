using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    [JsiiByValue(fqn: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditionsLabelNameCondition")]
    public class ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditionsLabelNameCondition : aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersLoggingFilterFiltersConditionsLabelNameCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#label_name ObservabilityadminTelemetryRuleForOrganization#label_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labelName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LabelName
        {
            get;
            set;
        }
    }
}
