using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationTagPropagationConfiguration")]
    public class ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationTagPropagationConfiguration : aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationTagPropagationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_centralization_rule_for_organization#destination_role_arn ObservabilityadminCentralizationRuleForOrganization#destination_role_arn}.</summary>
        [JsiiProperty(name: "destinationRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_centralization_rule_for_organization#tag_conflict_resolution_strategy ObservabilityadminCentralizationRuleForOrganization#tag_conflict_resolution_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagConflictResolutionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TagConflictResolutionStrategy
        {
            get;
            set;
        }
    }
}
