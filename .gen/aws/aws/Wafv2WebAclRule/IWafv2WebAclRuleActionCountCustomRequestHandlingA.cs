using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleActionCountCustomRequestHandlingA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleActionCountCustomRequestHandlingA")]
    public interface IWafv2WebAclRuleActionCountCustomRequestHandlingA
    {
        /// <summary>insert_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#insert_header Wafv2WebAclRuleA#insert_header}
        /// </remarks>
        [JsiiProperty(name: "insertHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleActionCountCustomRequestHandlingInsertHeaderA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InsertHeader
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleActionCountCustomRequestHandlingA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleActionCountCustomRequestHandlingA")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleActionCountCustomRequestHandlingA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>insert_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#insert_header Wafv2WebAclRuleA#insert_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "insertHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleActionCountCustomRequestHandlingInsertHeaderA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InsertHeader
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
