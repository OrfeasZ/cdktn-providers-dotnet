using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexMatchStatementFieldToMatchUriFragment")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexMatchStatementFieldToMatchUriFragment : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexMatchStatementFieldToMatchUriFragment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#fallback_behavior Wafv2WebAclRuleA#fallback_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fallbackBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FallbackBehavior
        {
            get;
            set;
        }
    }
}
