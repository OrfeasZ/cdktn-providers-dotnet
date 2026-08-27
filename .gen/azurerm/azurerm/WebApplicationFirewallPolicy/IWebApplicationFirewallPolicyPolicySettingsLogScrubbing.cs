using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IWebApplicationFirewallPolicyPolicySettingsLogScrubbing), fullyQualifiedName: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyPolicySettingsLogScrubbing")]
    public interface IWebApplicationFirewallPolicyPolicySettingsLogScrubbing
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/web_application_firewall_policy#enabled WebApplicationFirewallPolicy#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/web_application_firewall_policy#rule WebApplicationFirewallPolicy#rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyPolicySettingsLogScrubbingRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyPolicySettingsLogScrubbingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWebApplicationFirewallPolicyPolicySettingsLogScrubbing), fullyQualifiedName: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyPolicySettingsLogScrubbing")]
        internal sealed class _Proxy : DeputyBase, azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyPolicySettingsLogScrubbing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/web_application_firewall_policy#enabled WebApplicationFirewallPolicy#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/web_application_firewall_policy#rule WebApplicationFirewallPolicy#rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyPolicySettingsLogScrubbingRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyPolicySettingsLogScrubbingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rule
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
