using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementRegexMatchStatementFieldToMatchJa3Fingerprint), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementRegexMatchStatementFieldToMatchJa3Fingerprint")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementRegexMatchStatementFieldToMatchJa3Fingerprint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#fallback_behavior Wafv2WebAclRuleA#fallback_behavior}.</summary>
        [JsiiProperty(name: "fallbackBehavior", typeJson: "{\"primitive\":\"string\"}")]
        string FallbackBehavior
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementRegexMatchStatementFieldToMatchJa3Fingerprint), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementRegexMatchStatementFieldToMatchJa3Fingerprint")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementRegexMatchStatementFieldToMatchJa3Fingerprint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#fallback_behavior Wafv2WebAclRuleA#fallback_behavior}.</summary>
            [JsiiProperty(name: "fallbackBehavior", typeJson: "{\"primitive\":\"string\"}")]
            public string FallbackBehavior
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
