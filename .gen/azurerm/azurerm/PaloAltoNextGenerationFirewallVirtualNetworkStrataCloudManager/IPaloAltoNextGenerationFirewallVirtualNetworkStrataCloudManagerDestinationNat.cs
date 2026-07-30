using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager
{
    [JsiiInterface(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNat), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNat")]
    public interface IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNat
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#name PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#protocol PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>backend_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#backend_config PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#backend_config}
        /// </remarks>
        [JsiiProperty(name: "backendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatBackendConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatBackendConfig? BackendConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>frontend_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#frontend_config PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#frontend_config}
        /// </remarks>
        [JsiiProperty(name: "frontendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig? FrontendConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNat), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNat")]
        internal sealed class _Proxy : DeputyBase, azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#name PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#protocol PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>backend_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#backend_config PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#backend_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatBackendConfig\"}", isOptional: true)]
            public azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatBackendConfig? BackendConfig
            {
                get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatBackendConfig?>();
            }

            /// <summary>frontend_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/palo_alto_next_generation_firewall_virtual_network_strata_cloud_manager#frontend_config PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager#frontend_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frontendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig\"}", isOptional: true)]
            public azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig? FrontendConfig
            {
                get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualNetworkStrataCloudManagerDestinationNatFrontendConfig?>();
            }
        }
    }
}
