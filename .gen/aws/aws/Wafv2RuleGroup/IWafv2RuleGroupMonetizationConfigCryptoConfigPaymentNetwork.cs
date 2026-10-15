using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork")]
    public interface IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/wafv2_rule_group#chain Wafv2RuleGroup#chain}.</summary>
        [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}")]
        string Chain
        {
            get;
        }

        /// <summary>prices block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/wafv2_rule_group#prices Wafv2RuleGroup#prices}
        /// </remarks>
        [JsiiProperty(name: "prices", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices\"}")]
        aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices Prices
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/wafv2_rule_group#wallet_address Wafv2RuleGroup#wallet_address}.</summary>
        [JsiiProperty(name: "walletAddress", typeJson: "{\"primitive\":\"string\"}")]
        string WalletAddress
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/wafv2_rule_group#chain Wafv2RuleGroup#chain}.</summary>
            [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}")]
            public string Chain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>prices block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/wafv2_rule_group#prices Wafv2RuleGroup#prices}
            /// </remarks>
            [JsiiProperty(name: "prices", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices\"}")]
            public aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices Prices
            {
                get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/wafv2_rule_group#wallet_address Wafv2RuleGroup#wallet_address}.</summary>
            [JsiiProperty(name: "walletAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string WalletAddress
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
