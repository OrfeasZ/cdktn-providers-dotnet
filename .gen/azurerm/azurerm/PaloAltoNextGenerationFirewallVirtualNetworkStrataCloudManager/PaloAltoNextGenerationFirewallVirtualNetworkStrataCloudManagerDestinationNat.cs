using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNat")]
    public class PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNat : azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNat
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#name PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#protocol PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>backend_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#backend_config PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#backend_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatBackendConfig\"}", isOptional: true)]
        public azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatBackendConfig? BackendConfig
        {
            get;
            set;
        }

        /// <summary>frontend_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#frontend_config PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#frontend_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "frontendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig\"}", isOptional: true)]
        public azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig? FrontendConfig
        {
            get;
            set;
        }
    }
}
