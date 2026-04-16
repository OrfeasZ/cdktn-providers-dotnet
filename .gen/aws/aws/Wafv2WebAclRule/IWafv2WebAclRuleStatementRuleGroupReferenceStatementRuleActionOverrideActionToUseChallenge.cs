using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge")]
    public interface IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge
    {
        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#custom_request_handling Wafv2WebAclRuleA#custom_request_handling}
        /// </remarks>
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallengeCustomRequestHandling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomRequestHandling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_request_handling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#custom_request_handling Wafv2WebAclRuleA#custom_request_handling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customRequestHandling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallengeCustomRequestHandling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomRequestHandling
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
