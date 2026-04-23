using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains")]
    public class Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains : aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains
    {
        /// <summary>Strings that indicate a failed login or account creation attempt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#failure_strings Wafv2WebAclRuleGroupAssociation#failure_strings}
        /// </remarks>
        [JsiiProperty(name: "failureStrings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] FailureStrings
        {
            get;
            set;
        }

        /// <summary>Strings that indicate a successful login or account creation attempt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#success_strings Wafv2WebAclRuleGroupAssociation#success_strings}
        /// </remarks>
        [JsiiProperty(name: "successStrings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SuccessStrings
        {
            get;
            set;
        }
    }
}
