using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules")]
    public class DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules : aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules
    {
        /// <summary>rule_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#rule_definition DataAwsNetworkmanagerCoreNetworkPolicyDocument#rule_definition}
        /// </remarks>
        [JsiiProperty(name: "ruleDefinition", typeJson: "{\"fqn\":\"aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition\"}")]
        public aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition RuleDefinition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#rule_number DataAwsNetworkmanagerCoreNetworkPolicyDocument#rule_number}.</summary>
        [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
        public double RuleNumber
        {
            get;
            set;
        }
    }
}
