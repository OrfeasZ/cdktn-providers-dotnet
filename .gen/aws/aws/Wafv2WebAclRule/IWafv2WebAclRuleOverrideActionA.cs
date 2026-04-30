using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleOverrideActionA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleOverrideActionA")]
    public interface IWafv2WebAclRuleOverrideActionA
    {
        /// <summary>count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#count Wafv2WebAclRuleA#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleOverrideActionCountA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Count
        {
            get
            {
                return null;
            }
        }

        /// <summary>none block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#none Wafv2WebAclRuleA#none}
        /// </remarks>
        [JsiiProperty(name: "none", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleOverrideActionNoneA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? None
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleOverrideActionA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleOverrideActionA")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleOverrideActionA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#count Wafv2WebAclRuleA#count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleOverrideActionCountA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>none block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#none Wafv2WebAclRuleA#none}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "none", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleOverrideActionNoneA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? None
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
