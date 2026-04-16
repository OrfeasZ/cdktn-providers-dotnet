using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode")]
    public class Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode : aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode
    {
        /// <summary>Status codes that indicate a failed login or account creation attempt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#failure_codes Wafv2WebAclRuleGroupAssociation#failure_codes}
        /// </remarks>
        [JsiiProperty(name: "failureCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] FailureCodes
        {
            get;
            set;
        }

        /// <summary>Status codes that indicate a successful login or account creation attempt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule_group_association#success_codes Wafv2WebAclRuleGroupAssociation#success_codes}
        /// </remarks>
        [JsiiProperty(name: "successCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] SuccessCodes
        {
            get;
            set;
        }
    }
}
