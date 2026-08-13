using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup")]
    public class CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup : azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_batch_rule_set#cdn_frontdoor_origin_group_id CdnFrontdoorBatchRuleSet#cdn_frontdoor_origin_group_id}.</summary>
        [JsiiProperty(name: "cdnFrontdoorOriginGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string CdnFrontdoorOriginGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_batch_rule_set#forwarding_protocol CdnFrontdoorBatchRuleSet#forwarding_protocol}.</summary>
        [JsiiProperty(name: "forwardingProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public string ForwardingProtocol
        {
            get;
            set;
        }
    }
}
