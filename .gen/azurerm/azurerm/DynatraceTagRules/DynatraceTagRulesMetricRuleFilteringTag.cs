using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceTagRules
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dynatraceTagRules.DynatraceTagRulesMetricRuleFilteringTag")]
    public class DynatraceTagRulesMetricRuleFilteringTag : azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRuleFilteringTag
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dynatrace_tag_rules#action DynatraceTagRules#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dynatrace_tag_rules#name DynatraceTagRules#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dynatrace_tag_rules#value DynatraceTagRules#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
