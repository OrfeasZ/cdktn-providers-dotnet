using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.XrayIndexingRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.xrayIndexingRule.XrayIndexingRuleRuleProbabilistic")]
    public class XrayIndexingRuleRuleProbabilistic : aws.XrayIndexingRule.IXrayIndexingRuleRuleProbabilistic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/xray_indexing_rule#desired_sampling_percentage XrayIndexingRule#desired_sampling_percentage}.</summary>
        [JsiiProperty(name: "desiredSamplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public double DesiredSamplingPercentage
        {
            get;
            set;
        }
    }
}
