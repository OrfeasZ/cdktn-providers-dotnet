using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleActionMonetize), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleActionMonetize")]
    public interface IWafv2WebAclRuleActionMonetize
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#price_multiplier Wafv2WebAcl#price_multiplier}.</summary>
        [JsiiProperty(name: "priceMultiplier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PriceMultiplier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleActionMonetize), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleActionMonetize")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclRuleActionMonetize
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/wafv2_web_acl#price_multiplier Wafv2WebAcl#price_multiplier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priceMultiplier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PriceMultiplier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
