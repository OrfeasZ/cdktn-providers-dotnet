using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseChallenge), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseChallenge")]
    public interface IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseChallenge
    {
        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#custom_request_handling Wafv2WebAclRuleGroupAssociation#custom_request_handling}
        /// </remarks>
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomRequestHandling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseChallenge), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseChallenge")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseChallenge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_request_handling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#custom_request_handling Wafv2WebAclRuleGroupAssociation#custom_request_handling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customRequestHandling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomRequestHandling
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
