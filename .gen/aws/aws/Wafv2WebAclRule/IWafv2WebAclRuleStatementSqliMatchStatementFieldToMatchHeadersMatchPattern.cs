using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementSqliMatchStatementFieldToMatchHeadersMatchPattern), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementSqliMatchStatementFieldToMatchHeadersMatchPattern")]
    public interface IWafv2WebAclRuleStatementSqliMatchStatementFieldToMatchHeadersMatchPattern
    {
        /// <summary>all block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#all Wafv2WebAclRuleA#all}
        /// </remarks>
        [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementSqliMatchStatementFieldToMatchHeadersMatchPatternAll\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? All
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#excluded_headers Wafv2WebAclRuleA#excluded_headers}.</summary>
        [JsiiProperty(name: "excludedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#included_headers Wafv2WebAclRuleA#included_headers}.</summary>
        [JsiiProperty(name: "includedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedHeaders
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementSqliMatchStatementFieldToMatchHeadersMatchPattern), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementSqliMatchStatementFieldToMatchHeadersMatchPattern")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementSqliMatchStatementFieldToMatchHeadersMatchPattern
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#all Wafv2WebAclRuleA#all}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementSqliMatchStatementFieldToMatchHeadersMatchPatternAll\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? All
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#excluded_headers Wafv2WebAclRuleA#excluded_headers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedHeaders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#included_headers Wafv2WebAclRuleA#included_headers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedHeaders
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
