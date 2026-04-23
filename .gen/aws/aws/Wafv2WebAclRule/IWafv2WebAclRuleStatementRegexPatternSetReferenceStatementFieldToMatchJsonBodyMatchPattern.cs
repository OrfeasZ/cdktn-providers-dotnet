using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchJsonBodyMatchPattern), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchJsonBodyMatchPattern")]
    public interface IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchJsonBodyMatchPattern
    {
        /// <summary>all block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#all Wafv2WebAclRuleA#all}
        /// </remarks>
        [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchJsonBodyMatchPatternAll\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? All
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#included_paths Wafv2WebAclRuleA#included_paths}.</summary>
        [JsiiProperty(name: "includedPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedPaths
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchJsonBodyMatchPattern), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchJsonBodyMatchPattern")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchJsonBodyMatchPattern
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#all Wafv2WebAclRuleA#all}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchJsonBodyMatchPatternAll\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? All
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#included_paths Wafv2WebAclRuleA#included_paths}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedPaths
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
