using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration")]
    public class PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration : azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#virtual_network_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#virtual_network_id}.</summary>
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualNetworkId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#trusted_subnet_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#trusted_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustedSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#untrusted_subnet_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#untrusted_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "untrustedSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UntrustedSubnetId
        {
            get;
            set;
        }
    }
}
