using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRule
{
    [JsiiByValue(fqn: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationMskMonitoringParameters")]
    public class ObservabilityadminTelemetryRuleRuleDestinationConfigurationMskMonitoringParameters : aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationMskMonitoringParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule#enhanced_monitoring ObservabilityadminTelemetryRule#enhanced_monitoring}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnhancedMonitoring
        {
            get;
            set;
        }
    }
}
