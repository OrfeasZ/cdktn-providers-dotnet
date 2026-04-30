using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleCaptchaConfigImmunityTimePropertyA")]
    public class Wafv2WebAclRuleCaptchaConfigImmunityTimePropertyA : aws.Wafv2WebAclRule.IWafv2WebAclRuleCaptchaConfigImmunityTimePropertyA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#immunity_time Wafv2WebAclRuleA#immunity_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "immunityTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ImmunityTime
        {
            get;
            set;
        }
    }
}
