using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanGreTunnel
{
    [JsiiInterface(nativeType: typeof(IMagicWanGreTunnelConfig), fullyQualifiedName: "cloudflare.magicWanGreTunnel.MagicWanGreTunnelConfig")]
    public interface IMagicWanGreTunnelConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#account_id MagicWanGreTunnel#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>The IP address assigned to the Cloudflare side of the GRE tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#cloudflare_gre_endpoint MagicWanGreTunnel#cloudflare_gre_endpoint}
        /// </remarks>
        [JsiiProperty(name: "cloudflareGreEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string CloudflareGreEndpoint
        {
            get;
        }

        /// <summary>The IP address assigned to the customer side of the GRE tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#customer_gre_endpoint MagicWanGreTunnel#customer_gre_endpoint}
        /// </remarks>
        [JsiiProperty(name: "customerGreEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string CustomerGreEndpoint
        {
            get;
        }

        /// <summary>A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel.</summary>
        /// <remarks>
        /// Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#interface_address MagicWanGreTunnel#interface_address}
        /// </remarks>
        [JsiiProperty(name: "interfaceAddress", typeJson: "{\"primitive\":\"string\"}")]
        string InterfaceAddress
        {
            get;
        }

        /// <summary>The name of the tunnel.</summary>
        /// <remarks>
        /// The name cannot contain spaces or special characters, must be 15 characters or less, and cannot share a name with another GRE tunnel.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#name MagicWanGreTunnel#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>True if automatic stateful return routing should be enabled for a tunnel, false otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#automatic_return_routing MagicWanGreTunnel#automatic_return_routing}
        /// </remarks>
        [JsiiProperty(name: "automaticReturnRouting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutomaticReturnRouting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#bgp MagicWanGreTunnel#bgp}.</summary>
        [JsiiProperty(name: "bgp", typeJson: "{\"fqn\":\"cloudflare.magicWanGreTunnel.MagicWanGreTunnelBgp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelBgp? Bgp
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional description of the GRE tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#description MagicWanGreTunnel#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#health_check MagicWanGreTunnel#health_check}.</summary>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"cloudflare.magicWanGreTunnel.MagicWanGreTunnelHealthCheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelHealthCheck? HealthCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6.</summary>
        /// <remarks>
        /// Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#interface_address6 MagicWanGreTunnel#interface_address6}
        /// </remarks>
        [JsiiProperty(name: "interfaceAddress6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InterfaceAddress6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum Transmission Unit (MTU) in bytes for the GRE tunnel. The minimum value is 576.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#mtu MagicWanGreTunnel#mtu}
        /// </remarks>
        [JsiiProperty(name: "mtu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Mtu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Time To Live (TTL) in number of hops of the GRE tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#ttl MagicWanGreTunnel#ttl}
        /// </remarks>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ttl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicWanGreTunnelConfig), fullyQualifiedName: "cloudflare.magicWanGreTunnel.MagicWanGreTunnelConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#account_id MagicWanGreTunnel#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The IP address assigned to the Cloudflare side of the GRE tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#cloudflare_gre_endpoint MagicWanGreTunnel#cloudflare_gre_endpoint}
            /// </remarks>
            [JsiiProperty(name: "cloudflareGreEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudflareGreEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The IP address assigned to the customer side of the GRE tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#customer_gre_endpoint MagicWanGreTunnel#customer_gre_endpoint}
            /// </remarks>
            [JsiiProperty(name: "customerGreEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomerGreEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel.</summary>
            /// <remarks>
            /// Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#interface_address MagicWanGreTunnel#interface_address}
            /// </remarks>
            [JsiiProperty(name: "interfaceAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string InterfaceAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the tunnel.</summary>
            /// <remarks>
            /// The name cannot contain spaces or special characters, must be 15 characters or less, and cannot share a name with another GRE tunnel.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#name MagicWanGreTunnel#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>True if automatic stateful return routing should be enabled for a tunnel, false otherwise.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#automatic_return_routing MagicWanGreTunnel#automatic_return_routing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automaticReturnRouting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutomaticReturnRouting
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#bgp MagicWanGreTunnel#bgp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bgp", typeJson: "{\"fqn\":\"cloudflare.magicWanGreTunnel.MagicWanGreTunnelBgp\"}", isOptional: true)]
            public cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelBgp? Bgp
            {
                get => GetInstanceProperty<cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelBgp?>();
            }

            /// <summary>An optional description of the GRE tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#description MagicWanGreTunnel#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#health_check MagicWanGreTunnel#health_check}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"cloudflare.magicWanGreTunnel.MagicWanGreTunnelHealthCheck\"}", isOptional: true)]
            public cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelHealthCheck? HealthCheck
            {
                get => GetInstanceProperty<cloudflare.MagicWanGreTunnel.IMagicWanGreTunnelHealthCheck?>();
            }

            /// <summary>A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6.</summary>
            /// <remarks>
            /// Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#interface_address6 MagicWanGreTunnel#interface_address6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interfaceAddress6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InterfaceAddress6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Maximum Transmission Unit (MTU) in bytes for the GRE tunnel. The minimum value is 576.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#mtu MagicWanGreTunnel#mtu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mtu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Mtu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Time To Live (TTL) in number of hops of the GRE tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_gre_tunnel#ttl MagicWanGreTunnel#ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ttl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
