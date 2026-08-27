using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule")]
    public class CdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule : azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_firewall_policy#match_variable CdnFrontdoorFirewallPolicy#match_variable}.</summary>
        [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
        public string MatchVariable
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_firewall_policy#enabled CdnFrontdoorFirewallPolicy#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_firewall_policy#operator CdnFrontdoorFirewallPolicy#operator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_firewall_policy#selector CdnFrontdoorFirewallPolicy#selector}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Selector
        {
            get;
            set;
        }
    }
}
