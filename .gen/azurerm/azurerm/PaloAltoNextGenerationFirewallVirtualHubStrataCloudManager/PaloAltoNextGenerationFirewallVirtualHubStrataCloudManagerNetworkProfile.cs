using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerNetworkProfile")]
    public class PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerNetworkProfile : azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerNetworkProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#network_virtual_appliance_id PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#network_virtual_appliance_id}.</summary>
        [JsiiProperty(name: "networkVirtualApplianceId", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkVirtualApplianceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#public_ip_address_ids PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#public_ip_address_ids}.</summary>
        [JsiiProperty(name: "publicIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] PublicIpAddressIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#virtual_hub_id PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#virtual_hub_id}.</summary>
        [JsiiProperty(name: "virtualHubId", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualHubId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#egress_nat_ip_address_ids PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#egress_nat_ip_address_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "egressNatIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EgressNatIpAddressIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#trusted_address_ranges PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#trusted_address_ranges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrustedAddressRanges
        {
            get;
            set;
        }
    }
}
