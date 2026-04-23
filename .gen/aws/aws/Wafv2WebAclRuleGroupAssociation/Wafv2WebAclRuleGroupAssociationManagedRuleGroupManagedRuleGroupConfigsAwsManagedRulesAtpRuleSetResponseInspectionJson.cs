using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson")]
    public class Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson : aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson
    {
        /// <summary>Strings that indicate a failed login or account creation attempt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#failure_values Wafv2WebAclRuleGroupAssociation#failure_values}
        /// </remarks>
        [JsiiProperty(name: "failureValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] FailureValues
        {
            get;
            set;
        }

        /// <summary>Identifier of the JSON field to inspect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#identifier Wafv2WebAclRuleGroupAssociation#identifier}
        /// </remarks>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public string Identifier
        {
            get;
            set;
        }

        /// <summary>Strings that indicate a successful login or account creation attempt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#success_values Wafv2WebAclRuleGroupAssociation#success_values}
        /// </remarks>
        [JsiiProperty(name: "successValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SuccessValues
        {
            get;
            set;
        }
    }
}
