using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesException")]
    public class WebApplicationFirewallPolicyManagedRulesException : azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesException
    {
        private object _exceptionRuleSet;

        /// <summary>exception_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#exception_rule_set WebApplicationFirewallPolicy#exception_rule_set}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "exceptionRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet\"},\"kind\":\"array\"}}]}}")]
        public object ExceptionRuleSet
        {
            get => _exceptionRuleSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exceptionRuleSet = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#match_variable WebApplicationFirewallPolicy#match_variable}.</summary>
        [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
        public string MatchVariable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#value_match_operator WebApplicationFirewallPolicy#value_match_operator}.</summary>
        [JsiiProperty(name: "valueMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
        public string ValueMatchOperator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#values WebApplicationFirewallPolicy#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#selector WebApplicationFirewallPolicy#selector}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Selector
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#selector_match_operator WebApplicationFirewallPolicy#selector_match_operator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selectorMatchOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SelectorMatchOperator
        {
            get;
            set;
        }
    }
}
