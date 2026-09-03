using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager
{
    [JsiiInterface(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration")]
    public interface IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#virtual_network_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#virtual_network_id}.</summary>
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualNetworkId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#trusted_subnet_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#trusted_subnet_id}.</summary>
        [JsiiProperty(name: "trustedSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustedSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#untrusted_subnet_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#untrusted_subnet_id}.</summary>
        [JsiiProperty(name: "untrustedSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UntrustedSubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerNetworkProfileVnetConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#virtual_network_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#virtual_network_id}.</summary>
            [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#trusted_subnet_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#trusted_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustedSubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#untrusted_subnet_id PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#untrusted_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "untrustedSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UntrustedSubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
