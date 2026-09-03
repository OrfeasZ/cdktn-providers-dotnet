using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRouteCircuitPeering
{
    [JsiiInterface(nativeType: typeof(IExpressRouteCircuitPeeringConfig), fullyQualifiedName: "azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringConfig")]
    public interface IExpressRouteCircuitPeeringConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#express_route_circuit_name ExpressRouteCircuitPeering#express_route_circuit_name}.</summary>
        [JsiiProperty(name: "expressRouteCircuitName", typeJson: "{\"primitive\":\"string\"}")]
        string ExpressRouteCircuitName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#peering_type ExpressRouteCircuitPeering#peering_type}.</summary>
        [JsiiProperty(name: "peeringType", typeJson: "{\"primitive\":\"string\"}")]
        string PeeringType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#resource_group_name ExpressRouteCircuitPeering#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#vlan_id ExpressRouteCircuitPeering#vlan_id}.</summary>
        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"number\"}")]
        double VlanId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#id ExpressRouteCircuitPeering#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#ipv4_enabled ExpressRouteCircuitPeering#ipv4_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "ipv4Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv4Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>ipv6 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#ipv6 ExpressRouteCircuitPeering#ipv6}
        /// </remarks>
        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringIpv6\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringIpv6? Ipv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>microsoft_peering_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#microsoft_peering_config ExpressRouteCircuitPeering#microsoft_peering_config}
        /// </remarks>
        [JsiiProperty(name: "microsoftPeeringConfig", typeJson: "{\"fqn\":\"azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringMicrosoftPeeringConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringMicrosoftPeeringConfig? MicrosoftPeeringConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#peer_asn ExpressRouteCircuitPeering#peer_asn}.</summary>
        [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PeerAsn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#primary_peer_address_prefix ExpressRouteCircuitPeering#primary_peer_address_prefix}.</summary>
        [JsiiProperty(name: "primaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryPeerAddressPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#route_filter_id ExpressRouteCircuitPeering#route_filter_id}.</summary>
        [JsiiProperty(name: "routeFilterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteFilterId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#secondary_peer_address_prefix ExpressRouteCircuitPeering#secondary_peer_address_prefix}.</summary>
        [JsiiProperty(name: "secondaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecondaryPeerAddressPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#shared_key ExpressRouteCircuitPeering#shared_key}.</summary>
        [JsiiProperty(name: "sharedKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SharedKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#timeouts ExpressRouteCircuitPeering#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IExpressRouteCircuitPeeringConfig), fullyQualifiedName: "azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#express_route_circuit_name ExpressRouteCircuitPeering#express_route_circuit_name}.</summary>
            [JsiiProperty(name: "expressRouteCircuitName", typeJson: "{\"primitive\":\"string\"}")]
            public string ExpressRouteCircuitName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#peering_type ExpressRouteCircuitPeering#peering_type}.</summary>
            [JsiiProperty(name: "peeringType", typeJson: "{\"primitive\":\"string\"}")]
            public string PeeringType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#resource_group_name ExpressRouteCircuitPeering#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#vlan_id ExpressRouteCircuitPeering#vlan_id}.</summary>
            [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"number\"}")]
            public double VlanId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#id ExpressRouteCircuitPeering#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#ipv4_enabled ExpressRouteCircuitPeering#ipv4_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Ipv4Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ipv6 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#ipv6 ExpressRouteCircuitPeering#ipv6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringIpv6\"}", isOptional: true)]
            public azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringIpv6? Ipv6
            {
                get => GetInstanceProperty<azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringIpv6?>();
            }

            /// <summary>microsoft_peering_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#microsoft_peering_config ExpressRouteCircuitPeering#microsoft_peering_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "microsoftPeeringConfig", typeJson: "{\"fqn\":\"azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringMicrosoftPeeringConfig\"}", isOptional: true)]
            public azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringMicrosoftPeeringConfig? MicrosoftPeeringConfig
            {
                get => GetInstanceProperty<azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringMicrosoftPeeringConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#peer_asn ExpressRouteCircuitPeering#peer_asn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PeerAsn
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#primary_peer_address_prefix ExpressRouteCircuitPeering#primary_peer_address_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryPeerAddressPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#route_filter_id ExpressRouteCircuitPeering#route_filter_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routeFilterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteFilterId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#secondary_peer_address_prefix ExpressRouteCircuitPeering#secondary_peer_address_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecondaryPeerAddressPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#shared_key ExpressRouteCircuitPeering#shared_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sharedKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SharedKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/express_route_circuit_peering#timeouts ExpressRouteCircuitPeering#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringTimeouts\"}", isOptional: true)]
            public azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringTimeouts?>();
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
