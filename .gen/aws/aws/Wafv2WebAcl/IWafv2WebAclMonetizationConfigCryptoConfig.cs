using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclMonetizationConfigCryptoConfig), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfig")]
    public interface IWafv2WebAclMonetizationConfigCryptoConfig
    {
        /// <summary>payment_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl#payment_network Wafv2WebAcl#payment_network}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "paymentNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork\"},\"kind\":\"array\"}}]}}")]
        object PaymentNetwork
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclMonetizationConfigCryptoConfig), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>payment_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl#payment_network Wafv2WebAcl#payment_network}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "paymentNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork\"},\"kind\":\"array\"}}]}}")]
            public object PaymentNetwork
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
