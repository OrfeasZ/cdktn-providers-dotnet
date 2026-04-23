using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#field_to_match Wafv2WebAclRuleA#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatementFieldToMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#text_transformation Wafv2WebAclRuleA#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TextTransformation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#field_to_match Wafv2WebAclRuleA#field_to_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatementFieldToMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FieldToMatch
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>text_transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#text_transformation Wafv2WebAclRuleA#text_transformation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TextTransformation
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
