using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager
{
    [JsiiByValue(fqn: "azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDnsSettings")]
    public class PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDnsSettings : azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDnsSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#dns_servers PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#dns_servers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DnsServers
        {
            get;
            set;
        }

        private object? _useAzureDns;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#use_azure_dns PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#use_azure_dns}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useAzureDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseAzureDns
        {
            get => _useAzureDns;
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
                _useAzureDns = value;
            }
        }
    }
}
