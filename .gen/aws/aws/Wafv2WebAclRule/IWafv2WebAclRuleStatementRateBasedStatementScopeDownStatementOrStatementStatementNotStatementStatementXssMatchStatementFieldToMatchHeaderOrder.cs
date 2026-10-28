using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#oversize_handling Wafv2WebAclRuleA#oversize_handling}.</summary>
        [JsiiProperty(name: "oversizeHandling", typeJson: "{\"primitive\":\"string\"}")]
        string OversizeHandling
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#oversize_handling Wafv2WebAclRuleA#oversize_handling}.</summary>
            [JsiiProperty(name: "oversizeHandling", typeJson: "{\"primitive\":\"string\"}")]
            public string OversizeHandling
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
