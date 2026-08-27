using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallPolicyRuleCollectionGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupApplicationRuleCollection")]
    public class FirewallPolicyRuleCollectionGroupApplicationRuleCollection : azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupApplicationRuleCollection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/firewall_policy_rule_collection_group#action FirewallPolicyRuleCollectionGroup#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/firewall_policy_rule_collection_group#name FirewallPolicyRuleCollectionGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/firewall_policy_rule_collection_group#priority FirewallPolicyRuleCollectionGroup#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        private object _rule;

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/firewall_policy_rule_collection_group#rule FirewallPolicyRuleCollectionGroup#rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupApplicationRuleCollectionRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupApplicationRuleCollectionRule\"},\"kind\":\"array\"}}]}}")]
        public object Rule
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
                        case azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupApplicationRuleCollectionRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupApplicationRuleCollectionRule).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FirewallPolicyRuleCollectionGroup.IFirewallPolicyRuleCollectionGroupApplicationRuleCollectionRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rule = value;
            }
        }
    }
}
