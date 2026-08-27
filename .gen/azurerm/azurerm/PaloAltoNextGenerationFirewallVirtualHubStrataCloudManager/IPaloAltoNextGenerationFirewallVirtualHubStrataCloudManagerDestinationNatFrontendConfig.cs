using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager
{
    [JsiiInterface(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig")]
    public interface IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#port PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#public_ip_address_id PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#public_ip_address_id}.</summary>
        [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}")]
        string PublicIpAddressId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#port PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_strata_cloud_manager#public_ip_address_id PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager#public_ip_address_id}.</summary>
            [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicIpAddressId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
