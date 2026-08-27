using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    [JsiiByValue(fqn: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyPolicySettingsLogScrubbing")]
    public class WebApplicationFirewallPolicyPolicySettingsLogScrubbing : azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyPolicySettingsLogScrubbing
    {
        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/web_application_firewall_policy#enabled WebApplicationFirewallPolicy#enabled}.</summary>
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

        private object? _rule;

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/web_application_firewall_policy#rule WebApplicationFirewallPolicy#rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyPolicySettingsLogScrubbingRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyPolicySettingsLogScrubbingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyPolicySettingsLogScrubbingRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyPolicySettingsLogScrubbingRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rule = value;
            }
        }
    }
}
