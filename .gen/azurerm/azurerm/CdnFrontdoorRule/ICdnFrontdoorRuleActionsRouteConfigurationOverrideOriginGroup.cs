using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup")]
    public interface ICdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#cdn_frontdoor_origin_group_id CdnFrontdoorRule#cdn_frontdoor_origin_group_id}.</summary>
        [JsiiProperty(name: "cdnFrontdoorOriginGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string CdnFrontdoorOriginGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#forwarding_protocol CdnFrontdoorRule#forwarding_protocol}.</summary>
        [JsiiProperty(name: "forwardingProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string ForwardingProtocol
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#cdn_frontdoor_origin_group_id CdnFrontdoorRule#cdn_frontdoor_origin_group_id}.</summary>
            [JsiiProperty(name: "cdnFrontdoorOriginGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string CdnFrontdoorOriginGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#forwarding_protocol CdnFrontdoorRule#forwarding_protocol}.</summary>
            [JsiiProperty(name: "forwardingProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string ForwardingProtocol
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
