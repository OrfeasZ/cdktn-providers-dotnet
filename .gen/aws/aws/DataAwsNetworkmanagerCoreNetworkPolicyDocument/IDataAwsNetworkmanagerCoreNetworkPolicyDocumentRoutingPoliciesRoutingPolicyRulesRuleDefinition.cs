using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument
{
    [JsiiInterface(nativeType: typeof(IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition), fullyQualifiedName: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition")]
    public interface IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/networkmanager_core_network_policy_document#action DataAwsNetworkmanagerCoreNetworkPolicyDocument#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction\"}")]
        aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/networkmanager_core_network_policy_document#condition_logic DataAwsNetworkmanagerCoreNetworkPolicyDocument#condition_logic}.</summary>
        [JsiiProperty(name: "conditionLogic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConditionLogic
        {
            get
            {
                return null;
            }
        }

        /// <summary>match_conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/networkmanager_core_network_policy_document#match_conditions DataAwsNetworkmanagerCoreNetworkPolicyDocument#match_conditions}
        /// </remarks>
        [JsiiProperty(name: "matchConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionMatchConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchConditions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition), fullyQualifiedName: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/networkmanager_core_network_policy_document#action DataAwsNetworkmanagerCoreNetworkPolicyDocument#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction\"}")]
            public aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction Action
            {
                get => GetInstanceProperty<aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/networkmanager_core_network_policy_document#condition_logic DataAwsNetworkmanagerCoreNetworkPolicyDocument#condition_logic}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conditionLogic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConditionLogic
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>match_conditions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/networkmanager_core_network_policy_document#match_conditions DataAwsNetworkmanagerCoreNetworkPolicyDocument#match_conditions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionMatchConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchConditions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
