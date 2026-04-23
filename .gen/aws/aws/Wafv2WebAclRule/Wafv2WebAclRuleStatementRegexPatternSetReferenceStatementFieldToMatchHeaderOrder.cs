using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchHeaderOrder")]
    public class Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchHeaderOrder : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchHeaderOrder
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#oversize_handling Wafv2WebAclRuleA#oversize_handling}.</summary>
        [JsiiProperty(name: "oversizeHandling", typeJson: "{\"primitive\":\"string\"}")]
        public string OversizeHandling
        {
            get;
            set;
        }
    }
}
