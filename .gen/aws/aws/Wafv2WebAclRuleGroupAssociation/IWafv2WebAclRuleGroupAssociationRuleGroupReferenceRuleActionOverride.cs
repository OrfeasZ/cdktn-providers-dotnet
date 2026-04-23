using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverride), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverride")]
    public interface IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverride
    {
        /// <summary>Name of the rule to override.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#name Wafv2WebAclRuleGroupAssociation#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>action_to_use block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#action_to_use Wafv2WebAclRuleGroupAssociation#action_to_use}
        /// </remarks>
        [JsiiProperty(name: "actionToUse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ActionToUse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverride), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverride")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the rule to override.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#name Wafv2WebAclRuleGroupAssociation#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>action_to_use block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#action_to_use Wafv2WebAclRuleGroupAssociation#action_to_use}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "actionToUse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ActionToUse
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
