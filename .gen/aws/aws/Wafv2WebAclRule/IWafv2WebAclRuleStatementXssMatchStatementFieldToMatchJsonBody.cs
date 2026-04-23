using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementXssMatchStatementFieldToMatchJsonBody), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementXssMatchStatementFieldToMatchJsonBody")]
    public interface IWafv2WebAclRuleStatementXssMatchStatementFieldToMatchJsonBody
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#match_scope Wafv2WebAclRuleA#match_scope}.</summary>
        [JsiiProperty(name: "matchScope", typeJson: "{\"primitive\":\"string\"}")]
        string MatchScope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#invalid_fallback_behavior Wafv2WebAclRuleA#invalid_fallback_behavior}.</summary>
        [JsiiProperty(name: "invalidFallbackBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InvalidFallbackBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>match_pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#match_pattern Wafv2WebAclRuleA#match_pattern}
        /// </remarks>
        [JsiiProperty(name: "matchPattern", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementXssMatchStatementFieldToMatchJsonBodyMatchPattern\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#oversize_handling Wafv2WebAclRuleA#oversize_handling}.</summary>
        [JsiiProperty(name: "oversizeHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OversizeHandling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementXssMatchStatementFieldToMatchJsonBody), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementXssMatchStatementFieldToMatchJsonBody")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementXssMatchStatementFieldToMatchJsonBody
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#match_scope Wafv2WebAclRuleA#match_scope}.</summary>
            [JsiiProperty(name: "matchScope", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchScope
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#invalid_fallback_behavior Wafv2WebAclRuleA#invalid_fallback_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invalidFallbackBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InvalidFallbackBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>match_pattern block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#match_pattern Wafv2WebAclRuleA#match_pattern}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchPattern", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementXssMatchStatementFieldToMatchJsonBodyMatchPattern\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchPattern
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#oversize_handling Wafv2WebAclRuleA#oversize_handling}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oversizeHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OversizeHandling
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
