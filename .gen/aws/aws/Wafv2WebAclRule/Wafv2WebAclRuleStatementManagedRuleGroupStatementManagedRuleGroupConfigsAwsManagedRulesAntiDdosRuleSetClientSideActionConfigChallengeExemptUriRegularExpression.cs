using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallengeExemptUriRegularExpression")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallengeExemptUriRegularExpression : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallengeExemptUriRegularExpression
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#regex_string Wafv2WebAclRuleA#regex_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regexString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegexString
        {
            get;
            set;
        }
    }
}
