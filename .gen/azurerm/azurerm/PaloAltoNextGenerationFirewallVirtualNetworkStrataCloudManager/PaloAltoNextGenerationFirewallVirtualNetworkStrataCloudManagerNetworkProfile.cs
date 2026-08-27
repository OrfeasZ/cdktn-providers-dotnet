using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfile")]
    public class PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfile : azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#public_ip_address_ids PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#public_ip_address_ids}.</summary>
        [JsiiProperty(name: "publicIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] PublicIpAddressIds
        {
            get;
            set;
        }

        /// <summary>vnet_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#vnet_configuration PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#vnet_configuration}
        /// </remarks>
        [JsiiProperty(name: "vnetConfiguration", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration\"}")]
        public azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration VnetConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#egress_nat_ip_address_ids PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#egress_nat_ip_address_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "egressNatIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EgressNatIpAddressIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#trusted_address_ranges PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#trusted_address_ranges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrustedAddressRanges
        {
            get;
            set;
        }
    }
}
