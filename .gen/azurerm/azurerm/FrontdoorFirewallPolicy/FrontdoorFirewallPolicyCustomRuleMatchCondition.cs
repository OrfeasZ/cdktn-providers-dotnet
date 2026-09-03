using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FrontdoorFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.frontdoorFirewallPolicy.FrontdoorFirewallPolicyCustomRuleMatchCondition")]
    public class FrontdoorFirewallPolicyCustomRuleMatchCondition : azurerm.FrontdoorFirewallPolicy.IFrontdoorFirewallPolicyCustomRuleMatchCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/frontdoor_firewall_policy#match_values FrontdoorFirewallPolicy#match_values}.</summary>
        [JsiiProperty(name: "matchValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] MatchValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/frontdoor_firewall_policy#match_variable FrontdoorFirewallPolicy#match_variable}.</summary>
        [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
        public string MatchVariable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/frontdoor_firewall_policy#operator FrontdoorFirewallPolicy#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        private object? _negationCondition;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/frontdoor_firewall_policy#negation_condition FrontdoorFirewallPolicy#negation_condition}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "negationCondition", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? NegationCondition
        {
            get => _negationCondition;
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
                _negationCondition = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/frontdoor_firewall_policy#selector FrontdoorFirewallPolicy#selector}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Selector
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/frontdoor_firewall_policy#transforms FrontdoorFirewallPolicy#transforms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transforms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Transforms
        {
            get;
            set;
        }
    }
}
