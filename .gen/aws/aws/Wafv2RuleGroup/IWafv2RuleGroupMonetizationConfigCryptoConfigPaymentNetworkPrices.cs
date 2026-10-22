using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices")]
    public interface IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_rule_group#amount Wafv2RuleGroup#amount}.</summary>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"string\"}")]
        string Amount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_rule_group#currency Wafv2RuleGroup#currency}.</summary>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_rule_group#amount Wafv2RuleGroup#amount}.</summary>
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"string\"}")]
            public string Amount
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_rule_group#currency Wafv2RuleGroup#currency}.</summary>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
