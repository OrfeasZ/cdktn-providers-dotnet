using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesManagedRuleSetRuleGroupOverride")]
    public class WebApplicationFirewallPolicyManagedRulesManagedRuleSetRuleGroupOverride : azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesManagedRuleSetRuleGroupOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/web_application_firewall_policy#rule_group_name WebApplicationFirewallPolicy#rule_group_name}.</summary>
        [JsiiProperty(name: "ruleGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleGroupName
        {
            get;
            set;
        }

        private object? _rule;

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/web_application_firewall_policy#rule WebApplicationFirewallPolicy#rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesManagedRuleSetRuleGroupOverrideRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesManagedRuleSetRuleGroupOverrideRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Rule
        {
            get => _rule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesManagedRuleSetRuleGroupOverrideRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesManagedRuleSetRuleGroupOverrideRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rule = value;
            }
        }
    }
}
