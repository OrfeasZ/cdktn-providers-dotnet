using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationMskMonitoringParameters), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationMskMonitoringParameters")]
    public interface IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationMskMonitoringParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#enhanced_monitoring ObservabilityadminTelemetryRuleForOrganization#enhanced_monitoring}.</summary>
        [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnhancedMonitoring
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationMskMonitoringParameters), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationMskMonitoringParameters")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationMskMonitoringParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#enhanced_monitoring ObservabilityadminTelemetryRuleForOrganization#enhanced_monitoring}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnhancedMonitoring
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
