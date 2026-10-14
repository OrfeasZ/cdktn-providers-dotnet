using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork")]
    public interface IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#chain Wafv2WebAcl#chain}.</summary>
        [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}")]
        string Chain
        {
            get;
        }

        /// <summary>prices block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#prices Wafv2WebAcl#prices}
        /// </remarks>
        [JsiiProperty(name: "prices", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices\"}")]
        aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices Prices
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#wallet_address Wafv2WebAcl#wallet_address}.</summary>
        [JsiiProperty(name: "walletAddress", typeJson: "{\"primitive\":\"string\"}")]
        string WalletAddress
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#chain Wafv2WebAcl#chain}.</summary>
            [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}")]
            public string Chain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>prices block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#prices Wafv2WebAcl#prices}
            /// </remarks>
            [JsiiProperty(name: "prices", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices\"}")]
            public aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices Prices
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#wallet_address Wafv2WebAcl#wallet_address}.</summary>
            [JsiiProperty(name: "walletAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string WalletAddress
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
