using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule), fullyQualifiedName: "azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule")]
    public interface ICdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cdn_frontdoor_firewall_policy#match_variable CdnFrontdoorFirewallPolicy#match_variable}.</summary>
        [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
        string MatchVariable
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cdn_frontdoor_firewall_policy#enabled CdnFrontdoorFirewallPolicy#enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cdn_frontdoor_firewall_policy#operator CdnFrontdoorFirewallPolicy#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Operator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cdn_frontdoor_firewall_policy#selector CdnFrontdoorFirewallPolicy#selector}.</summary>
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Selector
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule), fullyQualifiedName: "azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cdn_frontdoor_firewall_policy#match_variable CdnFrontdoorFirewallPolicy#match_variable}.</summary>
            [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchVariable
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cdn_frontdoor_firewall_policy#enabled CdnFrontdoorFirewallPolicy#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cdn_frontdoor_firewall_policy#operator CdnFrontdoorFirewallPolicy#operator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Operator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cdn_frontdoor_firewall_policy#selector CdnFrontdoorFirewallPolicy#selector}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Selector
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
