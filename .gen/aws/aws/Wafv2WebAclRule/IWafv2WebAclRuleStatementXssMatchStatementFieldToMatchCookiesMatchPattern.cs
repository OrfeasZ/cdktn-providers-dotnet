using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementXssMatchStatementFieldToMatchCookiesMatchPattern), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementXssMatchStatementFieldToMatchCookiesMatchPattern")]
    public interface IWafv2WebAclRuleStatementXssMatchStatementFieldToMatchCookiesMatchPattern
    {
        /// <summary>all block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#all Wafv2WebAclRuleA#all}
        /// </remarks>
        [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementXssMatchStatementFieldToMatchCookiesMatchPatternAll\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? All
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#excluded_cookies Wafv2WebAclRuleA#excluded_cookies}.</summary>
        [JsiiProperty(name: "excludedCookies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedCookies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#included_cookies Wafv2WebAclRuleA#included_cookies}.</summary>
        [JsiiProperty(name: "includedCookies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedCookies
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementXssMatchStatementFieldToMatchCookiesMatchPattern), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementXssMatchStatementFieldToMatchCookiesMatchPattern")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementXssMatchStatementFieldToMatchCookiesMatchPattern
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#all Wafv2WebAclRuleA#all}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementXssMatchStatementFieldToMatchCookiesMatchPatternAll\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? All
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#excluded_cookies Wafv2WebAclRuleA#excluded_cookies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedCookies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedCookies
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#included_cookies Wafv2WebAclRuleA#included_cookies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedCookies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedCookies
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
