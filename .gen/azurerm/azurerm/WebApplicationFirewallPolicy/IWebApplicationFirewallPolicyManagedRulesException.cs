using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IWebApplicationFirewallPolicyManagedRulesException), fullyQualifiedName: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesException")]
    public interface IWebApplicationFirewallPolicyManagedRulesException
    {
        /// <summary>exception_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#exception_rule_set WebApplicationFirewallPolicy#exception_rule_set}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "exceptionRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet\"},\"kind\":\"array\"}}]}}")]
        object ExceptionRuleSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#match_variable WebApplicationFirewallPolicy#match_variable}.</summary>
        [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
        string MatchVariable
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#value_match_operator WebApplicationFirewallPolicy#value_match_operator}.</summary>
        [JsiiProperty(name: "valueMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ValueMatchOperator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#values WebApplicationFirewallPolicy#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#selector WebApplicationFirewallPolicy#selector}.</summary>
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Selector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#selector_match_operator WebApplicationFirewallPolicy#selector_match_operator}.</summary>
        [JsiiProperty(name: "selectorMatchOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelectorMatchOperator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWebApplicationFirewallPolicyManagedRulesException), fullyQualifiedName: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesException")]
        internal sealed class _Proxy : DeputyBase, azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesException
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>exception_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#exception_rule_set WebApplicationFirewallPolicy#exception_rule_set}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "exceptionRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExceptionExceptionRuleSet\"},\"kind\":\"array\"}}]}}")]
            public object ExceptionRuleSet
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#match_variable WebApplicationFirewallPolicy#match_variable}.</summary>
            [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchVariable
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#value_match_operator WebApplicationFirewallPolicy#value_match_operator}.</summary>
            [JsiiProperty(name: "valueMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueMatchOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#values WebApplicationFirewallPolicy#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#selector WebApplicationFirewallPolicy#selector}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Selector
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#selector_match_operator WebApplicationFirewallPolicy#selector_match_operator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selectorMatchOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelectorMatchOperator
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
