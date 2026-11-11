using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatchUriFragment), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatchUriFragment")]
    public interface IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatchUriFragment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/wafv2_web_acl_rule#fallback_behavior Wafv2WebAclRuleA#fallback_behavior}.</summary>
        [JsiiProperty(name: "fallbackBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FallbackBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatchUriFragment), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatchUriFragment")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatchUriFragment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/wafv2_web_acl_rule#fallback_behavior Wafv2WebAclRuleA#fallback_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fallbackBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FallbackBehavior
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
