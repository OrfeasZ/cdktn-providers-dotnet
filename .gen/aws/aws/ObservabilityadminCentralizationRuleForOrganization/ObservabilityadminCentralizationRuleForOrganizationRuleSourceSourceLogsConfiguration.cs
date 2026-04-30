using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceLogsConfiguration")]
    public class ObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceLogsConfiguration : aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceLogsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#encrypted_log_group_strategy ObservabilityadminCentralizationRuleForOrganization#encrypted_log_group_strategy}.</summary>
        [JsiiProperty(name: "encryptedLogGroupStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string EncryptedLogGroupStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#data_source_selection_criteria ObservabilityadminCentralizationRuleForOrganization#data_source_selection_criteria}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataSourceSelectionCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataSourceSelectionCriteria
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/observabilityadmin_centralization_rule_for_organization#log_group_selection_criteria ObservabilityadminCentralizationRuleForOrganization#log_group_selection_criteria}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroupSelectionCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroupSelectionCriteria
        {
            get;
            set;
        }
    }
}
