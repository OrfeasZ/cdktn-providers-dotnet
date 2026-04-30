using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleCaptchaConfigA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleCaptchaConfigA")]
    public interface IWafv2WebAclRuleCaptchaConfigA
    {
        /// <summary>immunity_time_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#immunity_time_property Wafv2WebAclRuleA#immunity_time_property}
        /// </remarks>
        [JsiiProperty(name: "immunityTimeProperty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleCaptchaConfigImmunityTimePropertyA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImmunityTimeProperty
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleCaptchaConfigA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleCaptchaConfigA")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleCaptchaConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>immunity_time_property block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#immunity_time_property Wafv2WebAclRuleA#immunity_time_property}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "immunityTimeProperty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleCaptchaConfigImmunityTimePropertyA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ImmunityTimeProperty
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
