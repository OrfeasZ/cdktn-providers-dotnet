using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSetRuleGroup")]
    public class WebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSetRuleGroup : azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSetRuleGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#rule_group_name WebApplicationFirewallPolicy#rule_group_name}.</summary>
        [JsiiProperty(name: "ruleGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#rules WebApplicationFirewallPolicy#rules}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Rules
        {
            get;
            set;
        }
    }
}
