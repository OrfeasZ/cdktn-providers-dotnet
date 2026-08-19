using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceMetricsConfiguration")]
    public class ObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceMetricsConfiguration : aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceMetricsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/observabilityadmin_centralization_rule_for_organization#metrics_selection_criteria ObservabilityadminCentralizationRuleForOrganization#metrics_selection_criteria}.</summary>
        [JsiiProperty(name: "metricsSelectionCriteria", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricsSelectionCriteria
        {
            get;
            set;
        }
    }
}
