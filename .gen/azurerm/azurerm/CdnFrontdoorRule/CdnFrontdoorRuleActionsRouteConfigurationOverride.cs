using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverride")]
    public class CdnFrontdoorRuleActionsRouteConfigurationOverride : azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverride
    {
        /// <summary>caching block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_rule#caching CdnFrontdoorRule#caching}
        /// </remarks>
        [JsiiProperty(name: "caching", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideCaching\"}")]
        public azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideCaching Caching
        {
            get;
            set;
        }

        /// <summary>origin_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_rule#origin_group CdnFrontdoorRule#origin_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originGroup", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup\"}", isOptional: true)]
        public azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup? OriginGroup
        {
            get;
            set;
        }
    }
}
