using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleCaptchaConfigImmunityTimePropertyA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleCaptchaConfigImmunityTimePropertyA")]
    public interface IWafv2WebAclRuleCaptchaConfigImmunityTimePropertyA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#immunity_time Wafv2WebAclRuleA#immunity_time}.</summary>
        [JsiiProperty(name: "immunityTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ImmunityTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleCaptchaConfigImmunityTimePropertyA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleCaptchaConfigImmunityTimePropertyA")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleCaptchaConfigImmunityTimePropertyA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#immunity_time Wafv2WebAclRuleA#immunity_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "immunityTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ImmunityTime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
