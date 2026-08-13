using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama
{
    [JsiiInterface(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualHubPanoramaConfig), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaConfig")]
    public interface IPaloAltoNextGenerationFirewallVirtualHubPanoramaConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#location PaloAltoNextGenerationFirewallVirtualHubPanorama#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#name PaloAltoNextGenerationFirewallVirtualHubPanorama#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>network_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#network_profile PaloAltoNextGenerationFirewallVirtualHubPanorama#network_profile}
        /// </remarks>
        [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile\"}")]
        azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile NetworkProfile
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#panorama_base64_config PaloAltoNextGenerationFirewallVirtualHubPanorama#panorama_base64_config}.</summary>
        [JsiiProperty(name: "panoramaBase64Config", typeJson: "{\"primitive\":\"string\"}")]
        string PanoramaBase64Config
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#resource_group_name PaloAltoNextGenerationFirewallVirtualHubPanorama#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>destination_nat block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#destination_nat PaloAltoNextGenerationFirewallVirtualHubPanorama#destination_nat}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNat" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "destinationNat", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DestinationNat
        {
            get
            {
                return null;
            }
        }

        /// <summary>dns_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#dns_settings PaloAltoNextGenerationFirewallVirtualHubPanorama#dns_settings}
        /// </remarks>
        [JsiiProperty(name: "dnsSettings", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaDnsSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaDnsSettings? DnsSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#id PaloAltoNextGenerationFirewallVirtualHubPanorama#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#marketplace_offer_id PaloAltoNextGenerationFirewallVirtualHubPanorama#marketplace_offer_id}.</summary>
        [JsiiProperty(name: "marketplaceOfferId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MarketplaceOfferId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#plan_id PaloAltoNextGenerationFirewallVirtualHubPanorama#plan_id}.</summary>
        [JsiiProperty(name: "planId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlanId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#tags PaloAltoNextGenerationFirewallVirtualHubPanorama#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#timeouts PaloAltoNextGenerationFirewallVirtualHubPanorama#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualHubPanoramaConfig), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#location PaloAltoNextGenerationFirewallVirtualHubPanorama#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#name PaloAltoNextGenerationFirewallVirtualHubPanorama#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>network_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#network_profile PaloAltoNextGenerationFirewallVirtualHubPanorama#network_profile}
            /// </remarks>
            [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile\"}")]
            public azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile NetworkProfile
            {
                get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#panorama_base64_config PaloAltoNextGenerationFirewallVirtualHubPanorama#panorama_base64_config}.</summary>
            [JsiiProperty(name: "panoramaBase64Config", typeJson: "{\"primitive\":\"string\"}")]
            public string PanoramaBase64Config
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#resource_group_name PaloAltoNextGenerationFirewallVirtualHubPanorama#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>destination_nat block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#destination_nat PaloAltoNextGenerationFirewallVirtualHubPanorama#destination_nat}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNat" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationNat", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DestinationNat
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>dns_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#dns_settings PaloAltoNextGenerationFirewallVirtualHubPanorama#dns_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsSettings", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaDnsSettings\"}", isOptional: true)]
            public azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaDnsSettings? DnsSettings
            {
                get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaDnsSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#id PaloAltoNextGenerationFirewallVirtualHubPanorama#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#marketplace_offer_id PaloAltoNextGenerationFirewallVirtualHubPanorama#marketplace_offer_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "marketplaceOfferId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MarketplaceOfferId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#plan_id PaloAltoNextGenerationFirewallVirtualHubPanorama#plan_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "planId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlanId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#tags PaloAltoNextGenerationFirewallVirtualHubPanorama#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#timeouts PaloAltoNextGenerationFirewallVirtualHubPanorama#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaTimeouts\"}", isOptional: true)]
            public azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
