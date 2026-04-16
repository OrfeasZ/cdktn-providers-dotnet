using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader")]
    public class Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#value Wafv2WebAclRuleA#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
