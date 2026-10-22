using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleActionMonetize), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionMonetize")]
    public interface IWafv2RuleGroupRuleActionMonetize
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_rule_group#price_multiplier Wafv2RuleGroup#price_multiplier}.</summary>
        [JsiiProperty(name: "priceMultiplier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PriceMultiplier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleActionMonetize), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionMonetize")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionMonetize
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/wafv2_rule_group#price_multiplier Wafv2RuleGroup#price_multiplier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priceMultiplier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PriceMultiplier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
