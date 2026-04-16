using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration")]
    public interface IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/observabilityadmin_centralization_rule_for_organization#encryption_strategy ObservabilityadminCentralizationRuleForOrganization#encryption_strategy}.</summary>
        [JsiiProperty(name: "encryptionStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string EncryptionStrategy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/observabilityadmin_centralization_rule_for_organization#encryption_conflict_resolution_strategy ObservabilityadminCentralizationRuleForOrganization#encryption_conflict_resolution_strategy}.</summary>
        [JsiiProperty(name: "encryptionConflictResolutionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionConflictResolutionStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/observabilityadmin_centralization_rule_for_organization#kms_key_arn ObservabilityadminCentralizationRuleForOrganization#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/observabilityadmin_centralization_rule_for_organization#encryption_strategy ObservabilityadminCentralizationRuleForOrganization#encryption_strategy}.</summary>
            [JsiiProperty(name: "encryptionStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string EncryptionStrategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/observabilityadmin_centralization_rule_for_organization#encryption_conflict_resolution_strategy ObservabilityadminCentralizationRuleForOrganization#encryption_conflict_resolution_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionConflictResolutionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionConflictResolutionStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/observabilityadmin_centralization_rule_for_organization#kms_key_arn ObservabilityadminCentralizationRuleForOrganization#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
