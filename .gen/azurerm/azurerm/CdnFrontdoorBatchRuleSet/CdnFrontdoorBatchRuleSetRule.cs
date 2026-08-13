using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRule")]
    public class CdnFrontdoorBatchRuleSetRule : azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRule
    {
        /// <summary>actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_batch_rule_set#actions CdnFrontdoorBatchRuleSet#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActions\"}")]
        public azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActions Actions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_batch_rule_set#name CdnFrontdoorBatchRuleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_batch_rule_set#order CdnFrontdoorBatchRuleSet#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public double Order
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_batch_rule_set#behaviour_on_match CdnFrontdoorBatchRuleSet#behaviour_on_match}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "behaviourOnMatch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BehaviourOnMatch
        {
            get;
            set;
        }

        /// <summary>conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_batch_rule_set#conditions CdnFrontdoorBatchRuleSet#conditions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditions\"}", isOptional: true)]
        public azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditions? Conditions
        {
            get;
            set;
        }
    }
}
