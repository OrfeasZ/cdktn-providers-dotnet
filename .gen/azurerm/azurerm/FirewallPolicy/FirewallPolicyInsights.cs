using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.firewallPolicy.FirewallPolicyInsights")]
    public class FirewallPolicyInsights : azurerm.FirewallPolicy.IFirewallPolicyInsights
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy#default_log_analytics_workspace_id FirewallPolicy#default_log_analytics_workspace_id}.</summary>
        [JsiiProperty(name: "defaultLogAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultLogAnalyticsWorkspaceId
        {
            get;
            set;
        }

        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy#enabled FirewallPolicy#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        private object? _logAnalyticsWorkspace;

        /// <summary>log_analytics_workspace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy#log_analytics_workspace FirewallPolicy#log_analytics_workspace}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FirewallPolicy.IFirewallPolicyInsightsLogAnalyticsWorkspace" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logAnalyticsWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyInsightsLogAnalyticsWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogAnalyticsWorkspace
        {
            get => _logAnalyticsWorkspace;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.FirewallPolicy.IFirewallPolicyInsightsLogAnalyticsWorkspace[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FirewallPolicy.IFirewallPolicyInsightsLogAnalyticsWorkspace).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logAnalyticsWorkspace = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/firewall_policy#retention_in_days FirewallPolicy#retention_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionInDays
        {
            get;
            set;
        }
    }
}
