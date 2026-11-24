using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet")]
    public class WebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet : azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#type WebApplicationFirewallPolicy#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#version WebApplicationFirewallPolicy#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        private object? _ruleGroup;

        /// <summary>rule_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#rule_group WebApplicationFirewallPolicy#rule_group}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSetRuleGroup" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSetRuleGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSetRuleGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSetRuleGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ruleGroup = value;
            }
        }
    }
}
