using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfig")]
    public class Wafv2WebAclMonetizationConfig : aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfig
    {
        /// <summary>crypto_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#crypto_config Wafv2WebAcl#crypto_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cryptoConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfig\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfig? CryptoConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#currency_mode Wafv2WebAcl#currency_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "currencyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CurrencyMode
        {
            get;
            set;
        }
    }
}
