using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorRuleConditionsSslProtocol), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocol")]
    public interface ICdnFrontdoorRuleConditionsSslProtocol
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#operator CdnFrontdoorRule#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#values CdnFrontdoorRule#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorRuleConditionsSslProtocol), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocol")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSslProtocol
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#operator CdnFrontdoorRule#operator}.</summary>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#values CdnFrontdoorRule#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
