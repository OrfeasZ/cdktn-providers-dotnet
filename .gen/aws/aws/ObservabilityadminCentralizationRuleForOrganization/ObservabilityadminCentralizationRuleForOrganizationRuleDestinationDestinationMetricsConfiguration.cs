using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    [JsiiByValue(fqn: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationMetricsConfiguration")]
    public class ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationMetricsConfiguration : aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationMetricsConfiguration
    {
        private object? _backupConfiguration;

        /// <summary>backup_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_centralization_rule_for_organization#backup_configuration ObservabilityadminCentralizationRuleForOrganization#backup_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationMetricsConfigurationBackupConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BackupConfiguration
        {
            get => _backupConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationMetricsConfigurationBackupConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationMetricsConfigurationBackupConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backupConfiguration = value;
            }
        }
    }
}
