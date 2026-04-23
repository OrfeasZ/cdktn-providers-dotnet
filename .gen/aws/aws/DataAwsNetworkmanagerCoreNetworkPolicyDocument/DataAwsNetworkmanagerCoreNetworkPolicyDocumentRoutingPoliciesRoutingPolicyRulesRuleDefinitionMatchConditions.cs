using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionMatchConditions")]
    public class DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionMatchConditions : aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionMatchConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#type DataAwsNetworkmanagerCoreNetworkPolicyDocument#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#value DataAwsNetworkmanagerCoreNetworkPolicyDocument#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
