using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager
{
    [JsiiInterface(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig")]
    public interface IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#port PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#public_ip_address_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#public_ip_address_id}.</summary>
        [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}")]
        string PublicIpAddressId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#port PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#public_ip_address_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#public_ip_address_id}.</summary>
            [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicIpAddressId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
