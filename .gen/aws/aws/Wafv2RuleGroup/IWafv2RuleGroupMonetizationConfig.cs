using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupMonetizationConfig), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfig")]
    public interface IWafv2RuleGroupMonetizationConfig
    {
        /// <summary>crypto_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_rule_group#crypto_config Wafv2RuleGroup#crypto_config}
        /// </remarks>
        [JsiiProperty(name: "cryptoConfig", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfig? CryptoConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_rule_group#currency_mode Wafv2RuleGroup#currency_mode}.</summary>
        [JsiiProperty(name: "currencyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CurrencyMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupMonetizationConfig), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>crypto_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_rule_group#crypto_config Wafv2RuleGroup#crypto_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cryptoConfig", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfig\"}", isOptional: true)]
            public aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfig? CryptoConfig
            {
                get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_rule_group#currency_mode Wafv2RuleGroup#currency_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "currencyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CurrencyMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
