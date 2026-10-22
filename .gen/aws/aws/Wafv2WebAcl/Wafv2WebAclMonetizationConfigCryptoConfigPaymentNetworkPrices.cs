using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices")]
    public class Wafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices : aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfigPaymentNetworkPrices
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#amount Wafv2WebAcl#amount}.</summary>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"string\"}")]
        public string Amount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#currency Wafv2WebAcl#currency}.</summary>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public string Currency
        {
            get;
            set;
        }
    }
}
