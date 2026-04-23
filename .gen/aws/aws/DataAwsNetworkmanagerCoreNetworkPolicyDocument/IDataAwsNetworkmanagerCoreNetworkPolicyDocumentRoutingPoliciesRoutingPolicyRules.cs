using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument
{
    [JsiiInterface(nativeType: typeof(IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules), fullyQualifiedName: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules")]
    public interface IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules
    {
        /// <summary>rule_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#rule_definition DataAwsNetworkmanagerCoreNetworkPolicyDocument#rule_definition}
        /// </remarks>
        [JsiiProperty(name: "ruleDefinition", typeJson: "{\"fqn\":\"aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition\"}")]
        aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition RuleDefinition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#rule_number DataAwsNetworkmanagerCoreNetworkPolicyDocument#rule_number}.</summary>
        [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
        double RuleNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules), fullyQualifiedName: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rule_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#rule_definition DataAwsNetworkmanagerCoreNetworkPolicyDocument#rule_definition}
            /// </remarks>
            [JsiiProperty(name: "ruleDefinition", typeJson: "{\"fqn\":\"aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition\"}")]
            public aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition RuleDefinition
            {
                get => GetInstanceProperty<aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#rule_number DataAwsNetworkmanagerCoreNetworkPolicyDocument#rule_number}.</summary>
            [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
            public double RuleNumber
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
