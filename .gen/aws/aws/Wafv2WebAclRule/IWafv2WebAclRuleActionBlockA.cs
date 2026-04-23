using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleActionBlockA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleActionBlockA")]
    public interface IWafv2WebAclRuleActionBlockA
    {
        /// <summary>custom_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#custom_response Wafv2WebAclRuleA#custom_response}
        /// </remarks>
        [JsiiProperty(name: "customResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleActionBlockCustomResponseA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomResponse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleActionBlockA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleActionBlockA")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleActionBlockA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#custom_response Wafv2WebAclRuleA#custom_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleActionBlockCustomResponseA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomResponse
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
