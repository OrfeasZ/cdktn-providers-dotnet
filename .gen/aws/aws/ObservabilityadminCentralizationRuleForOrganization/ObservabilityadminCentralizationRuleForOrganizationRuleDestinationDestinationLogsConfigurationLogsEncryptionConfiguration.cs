using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration")]
    public class ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration : aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#encryption_strategy ObservabilityadminCentralizationRuleForOrganization#encryption_strategy}.</summary>
        [JsiiProperty(name: "encryptionStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string EncryptionStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#encryption_conflict_resolution_strategy ObservabilityadminCentralizationRuleForOrganization#encryption_conflict_resolution_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionConflictResolutionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionConflictResolutionStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#kms_key_arn ObservabilityadminCentralizationRuleForOrganization#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }
    }
}
