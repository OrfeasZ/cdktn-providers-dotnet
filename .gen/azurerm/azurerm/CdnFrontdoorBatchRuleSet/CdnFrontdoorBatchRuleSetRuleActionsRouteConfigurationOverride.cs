using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride")]
    public class CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride : azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride
    {
        /// <summary>caching block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/cdn_frontdoor_batch_rule_set#caching CdnFrontdoorBatchRuleSet#caching}
        /// </remarks>
        [JsiiProperty(name: "caching", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCaching\"}")]
        public azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideCaching Caching
        {
            get;
            set;
        }

        /// <summary>origin_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/cdn_frontdoor_batch_rule_set#origin_group CdnFrontdoorBatchRuleSet#origin_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originGroup", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup\"}", isOptional: true)]
        public azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverrideOriginGroup? OriginGroup
        {
            get;
            set;
        }
    }
}
