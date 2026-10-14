using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfig")]
    public class Wafv2WebAclMonetizationConfigCryptoConfig : aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfig
    {
        private object _paymentNetwork;

        /// <summary>payment_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#payment_network Wafv2WebAcl#payment_network}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "paymentNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork\"},\"kind\":\"array\"}}]}}")]
        public object PaymentNetwork
        {
            get => _paymentNetwork;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _paymentNetwork = value;
            }
        }
    }
}
