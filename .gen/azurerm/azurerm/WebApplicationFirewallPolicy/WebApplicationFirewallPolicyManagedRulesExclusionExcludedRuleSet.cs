using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    [JsiiByValue(fqn: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSet")]
    public class WebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSet : azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSet
    {
        private object? _ruleGroup;

        /// <summary>rule_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/web_application_firewall_policy#rule_group WebApplicationFirewallPolicy#rule_group}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSetRuleGroup" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSetRuleGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RuleGroup
        {
            get => _ruleGroup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSetRuleGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSetRuleGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ruleGroup = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/web_application_firewall_policy#type WebApplicationFirewallPolicy#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/web_application_firewall_policy#version WebApplicationFirewallPolicy#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
