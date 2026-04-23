using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfiguration), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfiguration")]
    public interface IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfiguration
    {
        /// <summary>backup_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#backup_configuration ObservabilityadminCentralizationRuleForOrganization#backup_configuration}
        /// </remarks>
        [JsiiProperty(name: "backupConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationBackupConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BackupConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_group_name_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#log_group_name_configuration ObservabilityadminCentralizationRuleForOrganization#log_group_name_configuration}
        /// </remarks>
        [JsiiProperty(name: "logGroupNameConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogGroupNameConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogGroupNameConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>logs_encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#logs_encryption_configuration ObservabilityadminCentralizationRuleForOrganization#logs_encryption_configuration}
        /// </remarks>
        [JsiiProperty(name: "logsEncryptionConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogsEncryptionConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfiguration), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>backup_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#backup_configuration ObservabilityadminCentralizationRuleForOrganization#backup_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationBackupConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BackupConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>log_group_name_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#log_group_name_configuration ObservabilityadminCentralizationRuleForOrganization#log_group_name_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logGroupNameConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogGroupNameConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogGroupNameConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>logs_encryption_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#logs_encryption_configuration ObservabilityadminCentralizationRuleForOrganization#logs_encryption_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logsEncryptionConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogsEncryptionConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogsEncryptionConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
