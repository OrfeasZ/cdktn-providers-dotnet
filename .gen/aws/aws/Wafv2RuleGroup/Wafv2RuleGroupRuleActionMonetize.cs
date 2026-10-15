using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiByValue(fqn: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionMonetize")]
    public class Wafv2RuleGroupRuleActionMonetize : aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionMonetize
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/wafv2_rule_group#price_multiplier Wafv2RuleGroup#price_multiplier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priceMultiplier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PriceMultiplier
        {
            get;
            set;
        }
    }
}
