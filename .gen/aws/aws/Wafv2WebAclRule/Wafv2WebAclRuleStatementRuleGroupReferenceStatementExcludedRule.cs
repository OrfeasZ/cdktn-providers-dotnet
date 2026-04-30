using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementExcludedRule")]
    public class Wafv2WebAclRuleStatementRuleGroupReferenceStatementExcludedRule : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementExcludedRule
    {
        /// <summary>Name of the rule to exclude (1-128 characters).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
