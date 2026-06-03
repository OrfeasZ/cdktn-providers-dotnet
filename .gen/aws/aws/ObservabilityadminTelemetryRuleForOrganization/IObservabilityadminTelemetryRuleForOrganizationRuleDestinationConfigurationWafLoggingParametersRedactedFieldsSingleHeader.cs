using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersRedactedFieldsSingleHeader), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersRedactedFieldsSingleHeader")]
    public interface IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersRedactedFieldsSingleHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.48.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#name ObservabilityadminTelemetryRuleForOrganization#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersRedactedFieldsSingleHeader), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersRedactedFieldsSingleHeader")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationWafLoggingParametersRedactedFieldsSingleHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.48.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#name ObservabilityadminTelemetryRuleForOrganization#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
