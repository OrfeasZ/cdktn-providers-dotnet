using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceLogsConfiguration), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceLogsConfiguration")]
    public interface IObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceLogsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#encrypted_log_group_strategy ObservabilityadminCentralizationRuleForOrganization#encrypted_log_group_strategy}.</summary>
        [JsiiProperty(name: "encryptedLogGroupStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string EncryptedLogGroupStrategy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#data_source_selection_criteria ObservabilityadminCentralizationRuleForOrganization#data_source_selection_criteria}.</summary>
        [JsiiProperty(name: "dataSourceSelectionCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSourceSelectionCriteria
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#log_group_selection_criteria ObservabilityadminCentralizationRuleForOrganization#log_group_selection_criteria}.</summary>
        [JsiiProperty(name: "logGroupSelectionCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroupSelectionCriteria
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceLogsConfiguration), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceLogsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceLogsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#encrypted_log_group_strategy ObservabilityadminCentralizationRuleForOrganization#encrypted_log_group_strategy}.</summary>
            [JsiiProperty(name: "encryptedLogGroupStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string EncryptedLogGroupStrategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#data_source_selection_criteria ObservabilityadminCentralizationRuleForOrganization#data_source_selection_criteria}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataSourceSelectionCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSourceSelectionCriteria
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#log_group_selection_criteria ObservabilityadminCentralizationRuleForOrganization#log_group_selection_criteria}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroupSelectionCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroupSelectionCriteria
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
