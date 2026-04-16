using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatementFieldToMatchBody")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatementFieldToMatchBody : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatementFieldToMatchBody
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#oversize_handling Wafv2WebAclRuleA#oversize_handling}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oversizeHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OversizeHandling
        {
            get;
            set;
        }
    }
}
