using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogGroupNameConfiguration")]
    public class ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogGroupNameConfiguration : aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationLogGroupNameConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#log_group_name_pattern ObservabilityadminCentralizationRuleForOrganization#log_group_name_pattern}.</summary>
        [JsiiProperty(name: "logGroupNamePattern", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupNamePattern
        {
            get;
            set;
        }
    }
}
