using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    [JsiiByValue(fqn: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectors")]
    public class ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectors : aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectors
    {
        private object? _fieldSelectors;

        /// <summary>field_selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#field_selectors ObservabilityadminTelemetryRuleForOrganization#field_selectors}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldSelectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FieldSelectors
        {
            get => _fieldSelectors;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fieldSelectors = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_telemetry_rule_for_organization#name ObservabilityadminTelemetryRuleForOrganization#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
