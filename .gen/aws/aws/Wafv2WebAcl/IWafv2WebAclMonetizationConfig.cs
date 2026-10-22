using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclMonetizationConfig), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfig")]
    public interface IWafv2WebAclMonetizationConfig
    {
        /// <summary>crypto_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#crypto_config Wafv2WebAcl#crypto_config}
        /// </remarks>
        [JsiiProperty(name: "cryptoConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfig? CryptoConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#currency_mode Wafv2WebAcl#currency_mode}.</summary>
        [JsiiProperty(name: "currencyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CurrencyMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclMonetizationConfig), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclMonetizationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>crypto_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#crypto_config Wafv2WebAcl#crypto_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cryptoConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclMonetizationConfigCryptoConfig\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfig? CryptoConfig
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclMonetizationConfigCryptoConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_web_acl#currency_mode Wafv2WebAcl#currency_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "currencyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CurrencyMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
