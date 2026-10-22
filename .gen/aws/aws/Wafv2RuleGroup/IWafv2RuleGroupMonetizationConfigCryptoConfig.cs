using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupMonetizationConfigCryptoConfig), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfig")]
    public interface IWafv2RuleGroupMonetizationConfigCryptoConfig
    {
        /// <summary>payment_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_rule_group#payment_network Wafv2RuleGroup#payment_network}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "paymentNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork\"},\"kind\":\"array\"}}]}}")]
        object PaymentNetwork
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupMonetizationConfigCryptoConfig), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>payment_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_rule_group#payment_network Wafv2RuleGroup#payment_network}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "paymentNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork\"},\"kind\":\"array\"}}]}}")]
            public object PaymentNetwork
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
