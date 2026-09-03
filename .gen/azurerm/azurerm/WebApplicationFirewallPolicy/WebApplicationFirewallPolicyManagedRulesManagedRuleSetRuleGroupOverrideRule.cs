using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesManagedRuleSetRuleGroupOverrideRule")]
    public class WebApplicationFirewallPolicyManagedRulesManagedRuleSetRuleGroupOverrideRule : azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesManagedRuleSetRuleGroupOverrideRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/web_application_firewall_policy#id WebApplicationFirewallPolicy#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/web_application_firewall_policy#action WebApplicationFirewallPolicy#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/web_application_firewall_policy#enabled WebApplicationFirewallPolicy#enabled}.</summary>
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
    }
}
