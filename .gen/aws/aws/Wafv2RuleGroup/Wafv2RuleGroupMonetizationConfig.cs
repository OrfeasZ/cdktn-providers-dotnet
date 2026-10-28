using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiByValue(fqn: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfig")]
    public class Wafv2RuleGroupMonetizationConfig : aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfig
    {
        /// <summary>crypto_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_rule_group#crypto_config Wafv2RuleGroup#crypto_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cryptoConfig", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfig\"}", isOptional: true)]
        public aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfig? CryptoConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_rule_group#currency_mode Wafv2RuleGroup#currency_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "currencyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CurrencyMode
        {
            get;
            set;
        }
    }
}
