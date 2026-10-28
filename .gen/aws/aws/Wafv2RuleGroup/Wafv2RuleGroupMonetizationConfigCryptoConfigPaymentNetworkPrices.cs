using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices")]
    public class Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices : aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_rule_group#amount Wafv2RuleGroup#amount}.</summary>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"string\"}")]
        public string Amount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_rule_group#currency Wafv2RuleGroup#currency}.</summary>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public string Currency
        {
            get;
            set;
        }
    }
}
