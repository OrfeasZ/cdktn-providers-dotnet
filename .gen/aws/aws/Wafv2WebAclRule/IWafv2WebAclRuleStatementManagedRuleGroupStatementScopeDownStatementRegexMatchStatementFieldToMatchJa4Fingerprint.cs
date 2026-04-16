using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexMatchStatementFieldToMatchJa4Fingerprint), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexMatchStatementFieldToMatchJa4Fingerprint")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexMatchStatementFieldToMatchJa4Fingerprint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#fallback_behavior Wafv2WebAclRuleA#fallback_behavior}.</summary>
        [JsiiProperty(name: "fallbackBehavior", typeJson: "{\"primitive\":\"string\"}")]
        string FallbackBehavior
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexMatchStatementFieldToMatchJa4Fingerprint), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexMatchStatementFieldToMatchJa4Fingerprint")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexMatchStatementFieldToMatchJa4Fingerprint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#fallback_behavior Wafv2WebAclRuleA#fallback_behavior}.</summary>
            [JsiiProperty(name: "fallbackBehavior", typeJson: "{\"primitive\":\"string\"}")]
            public string FallbackBehavior
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
