using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork")]
    public class Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork : aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl#chain Wafv2WebAcl#chain}.</summary>
        [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}")]
        public string Chain
        {
            get;
            set;
        }

        /// <summary>prices block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl#prices Wafv2WebAcl#prices}
        /// </remarks>
        [JsiiProperty(name: "prices", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices\"}")]
        public aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices Prices
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/wafv2_web_acl#wallet_address Wafv2WebAcl#wallet_address}.</summary>
        [JsiiProperty(name: "walletAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string WalletAddress
        {
            get;
            set;
        }
    }
}
