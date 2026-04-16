using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementLabelMatchStatement), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementLabelMatchStatement")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementLabelMatchStatement
    {
        /// <summary>String to match against. Must be 1-1024 characters and match pattern ^[0-9A-Za-z_\-:]+$.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#key Wafv2WebAclRuleA#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Specify whether to match using the label name or just the namespace. Valid values: LABEL, NAMESPACE.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#scope Wafv2WebAclRuleA#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementLabelMatchStatement), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementLabelMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementLabelMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>String to match against. Must be 1-1024 characters and match pattern ^[0-9A-Za-z_\-:]+$.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#key Wafv2WebAclRuleA#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specify whether to match using the label name or just the namespace. Valid values: LABEL, NAMESPACE.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#scope Wafv2WebAclRuleA#scope}
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
