using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader")]
    public class Wafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader : aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#name Wafv2WebAclRuleGroupAssociation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#value Wafv2WebAclRuleGroupAssociation#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
