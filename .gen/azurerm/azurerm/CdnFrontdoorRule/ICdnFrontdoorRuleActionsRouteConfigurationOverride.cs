using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorRuleActionsRouteConfigurationOverride), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverride")]
    public interface ICdnFrontdoorRuleActionsRouteConfigurationOverride
    {
        /// <summary>caching block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_rule#caching CdnFrontdoorRule#caching}
        /// </remarks>
        [JsiiProperty(name: "caching", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideCaching\"}")]
        azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideCaching Caching
        {
            get;
        }

        /// <summary>origin_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_rule#origin_group CdnFrontdoorRule#origin_group}
        /// </remarks>
        [JsiiProperty(name: "originGroup", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup? OriginGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorRuleActionsRouteConfigurationOverride), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverride")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>caching block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_rule#caching CdnFrontdoorRule#caching}
            /// </remarks>
            [JsiiProperty(name: "caching", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideCaching\"}")]
            public azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideCaching Caching
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideCaching>()!;
            }

            /// <summary>origin_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_rule#origin_group CdnFrontdoorRule#origin_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originGroup", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup\"}", isOptional: true)]
            public azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup? OriginGroup
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideOriginGroup?>();
            }
        }
    }
}
