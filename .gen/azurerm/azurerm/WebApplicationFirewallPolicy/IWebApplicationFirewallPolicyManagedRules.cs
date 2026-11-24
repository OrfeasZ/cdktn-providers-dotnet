using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IWebApplicationFirewallPolicyManagedRules), fullyQualifiedName: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRules")]
    public interface IWebApplicationFirewallPolicyManagedRules
    {
        /// <summary>managed_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#managed_rule_set WebApplicationFirewallPolicy#managed_rule_set}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesManagedRuleSet" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "managedRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesManagedRuleSet\"},\"kind\":\"array\"}}]}}")]
        object ManagedRuleSet
        {
            get;
        }

        /// <summary>exception block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#exception WebApplicationFirewallPolicy#exception}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesException" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "exception", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesException\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Exception
        {
            get
            {
                return null;
            }
        }

        /// <summary>exclusion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#exclusion WebApplicationFirewallPolicy#exclusion}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusion" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "exclusion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExclusion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Exclusion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWebApplicationFirewallPolicyManagedRules), fullyQualifiedName: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRules")]
        internal sealed class _Proxy : DeputyBase, azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>managed_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#managed_rule_set WebApplicationFirewallPolicy#managed_rule_set}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesManagedRuleSet" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "managedRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesManagedRuleSet\"},\"kind\":\"array\"}}]}}")]
            public object ManagedRuleSet
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>exception block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#exception WebApplicationFirewallPolicy#exception}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesException" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exception", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesException\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Exception
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>exclusion block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/web_application_firewall_policy#exclusion WebApplicationFirewallPolicy#exclusion}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusion" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclusion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExclusion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Exclusion
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
