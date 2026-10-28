using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader
    {
        /// <summary>Header name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Header name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
