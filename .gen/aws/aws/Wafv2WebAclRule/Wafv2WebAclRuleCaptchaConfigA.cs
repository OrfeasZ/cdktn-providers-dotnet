using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleCaptchaConfigA")]
    public class Wafv2WebAclRuleCaptchaConfigA : aws.Wafv2WebAclRule.IWafv2WebAclRuleCaptchaConfigA
    {
        private object? _immunityTimeProperty;

        /// <summary>immunity_time_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#immunity_time_property Wafv2WebAclRuleA#immunity_time_property}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "immunityTimeProperty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleCaptchaConfigImmunityTimePropertyA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ImmunityTimeProperty
        {
            get => _immunityTimeProperty;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleCaptchaConfigImmunityTimePropertyA[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleCaptchaConfigImmunityTimePropertyA).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _immunityTimeProperty = value;
            }
        }
    }
}
