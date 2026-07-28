using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup")]
    public interface ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/cdn_frontdoor_batch_rule_set#cdn_frontdoor_origin_group_id CdnFrontdoorBatchRuleSet#cdn_frontdoor_origin_group_id}.</summary>
        [JsiiProperty(name: "cdnFrontdoorOriginGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string CdnFrontdoorOriginGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/cdn_frontdoor_batch_rule_set#forwarding_protocol CdnFrontdoorBatchRuleSet#forwarding_protocol}.</summary>
        [JsiiProperty(name: "forwardingProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string ForwardingProtocol
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/cdn_frontdoor_batch_rule_set#cdn_frontdoor_origin_group_id CdnFrontdoorBatchRuleSet#cdn_frontdoor_origin_group_id}.</summary>
            [JsiiProperty(name: "cdnFrontdoorOriginGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string CdnFrontdoorOriginGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/cdn_frontdoor_batch_rule_set#forwarding_protocol CdnFrontdoorBatchRuleSet#forwarding_protocol}.</summary>
            [JsiiProperty(name: "forwardingProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string ForwardingProtocol
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
