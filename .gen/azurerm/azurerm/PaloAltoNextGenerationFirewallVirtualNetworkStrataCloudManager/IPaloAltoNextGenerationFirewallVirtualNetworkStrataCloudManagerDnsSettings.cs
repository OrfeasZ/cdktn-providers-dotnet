using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager
{
    [JsiiInterface(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDnsSettings), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDnsSettings")]
    public interface IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDnsSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#dns_servers PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#dns_servers}.</summary>
        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DnsServers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#use_azure_dns PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#use_azure_dns}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useAzureDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseAzureDns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDnsSettings), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDnsSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDnsSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#dns_servers PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#dns_servers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DnsServers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#use_azure_dns PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#use_azure_dns}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useAzureDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseAzureDns
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
