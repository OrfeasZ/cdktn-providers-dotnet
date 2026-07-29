using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationVpcFlowLogParameters), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationVpcFlowLogParameters")]
    public interface IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationVpcFlowLogParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#log_format ObservabilityadminTelemetryRuleForOrganization#log_format}.</summary>
        [JsiiProperty(name: "logFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#max_aggregation_interval ObservabilityadminTelemetryRuleForOrganization#max_aggregation_interval}.</summary>
        [JsiiProperty(name: "maxAggregationInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAggregationInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#traffic_type ObservabilityadminTelemetryRuleForOrganization#traffic_type}.</summary>
        [JsiiProperty(name: "trafficType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrafficType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationVpcFlowLogParameters), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationVpcFlowLogParameters")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationVpcFlowLogParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#log_format ObservabilityadminTelemetryRuleForOrganization#log_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#max_aggregation_interval ObservabilityadminTelemetryRuleForOrganization#max_aggregation_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxAggregationInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAggregationInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#traffic_type ObservabilityadminTelemetryRuleForOrganization#traffic_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trafficType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrafficType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
