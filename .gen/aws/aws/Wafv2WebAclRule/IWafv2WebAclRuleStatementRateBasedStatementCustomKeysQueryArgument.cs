using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementCustomKeysQueryArgument), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementCustomKeysQueryArgument")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementCustomKeysQueryArgument
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#text_transformation Wafv2WebAclRuleA#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementCustomKeysQueryArgumentTextTransformation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TextTransformation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementCustomKeysQueryArgument), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementCustomKeysQueryArgument")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementCustomKeysQueryArgument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>text_transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#text_transformation Wafv2WebAclRuleA#text_transformation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementCustomKeysQueryArgumentTextTransformation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TextTransformation
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
