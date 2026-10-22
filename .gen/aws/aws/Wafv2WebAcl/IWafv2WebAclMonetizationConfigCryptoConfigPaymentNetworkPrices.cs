using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices")]
    public interface IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#amount Wafv2WebAcl#amount}.</summary>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"string\"}")]
        string Amount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#currency Wafv2WebAcl#currency}.</summary>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#amount Wafv2WebAcl#amount}.</summary>
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"string\"}")]
            public string Amount
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#currency Wafv2WebAcl#currency}.</summary>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
