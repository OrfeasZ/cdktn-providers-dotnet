using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork")]
    public class Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork : aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/wafv2_rule_group#chain Wafv2RuleGroup#chain}.</summary>
        [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}")]
        public string Chain
        {
            get;
            set;
        }

        /// <summary>prices block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/wafv2_rule_group#prices Wafv2RuleGroup#prices}
        /// </remarks>
        [JsiiProperty(name: "prices", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices\"}")]
        public aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices Prices
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/wafv2_rule_group#wallet_address Wafv2RuleGroup#wallet_address}.</summary>
        [JsiiProperty(name: "walletAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string WalletAddress
        {
            get;
            set;
        }
    }
}
