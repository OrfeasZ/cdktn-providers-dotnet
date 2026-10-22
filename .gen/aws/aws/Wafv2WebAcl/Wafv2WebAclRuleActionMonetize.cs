using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclRuleActionMonetize")]
    public class Wafv2WebAclRuleActionMonetize : aws.Wafv2WebAcl.IWafv2WebAclRuleActionMonetize
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#price_multiplier Wafv2WebAcl#price_multiplier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priceMultiplier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PriceMultiplier
        {
            get;
            set;
        }
    }
}
