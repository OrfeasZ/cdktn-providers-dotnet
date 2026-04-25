using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanIpsecTunnel
{
    [JsiiInterface(nativeType: typeof(IMagicWanIpsecTunnelConfig), fullyQualifiedName: "cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelConfig")]
    public interface IMagicWanIpsecTunnelConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#account_id MagicWanIpsecTunnel#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>The IP address assigned to the Cloudflare side of the IPsec tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#cloudflare_endpoint MagicWanIpsecTunnel#cloudflare_endpoint}
        /// </remarks>
        [JsiiProperty(name: "cloudflareEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string CloudflareEndpoint
        {
            get;
        }

        /// <summary>A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel.</summary>
        /// <remarks>
        /// Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#interface_address MagicWanIpsecTunnel#interface_address}
        /// </remarks>
        [JsiiProperty(name: "interfaceAddress", typeJson: "{\"primitive\":\"string\"}")]
        string InterfaceAddress
        {
            get;
        }

        /// <summary>The name of the IPsec tunnel. The name cannot share a name with other tunnels.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#name MagicWanIpsecTunnel#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>True if automatic stateful return routing should be enabled for a tunnel, false otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#automatic_return_routing MagicWanIpsecTunnel#automatic_return_routing}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#bgp MagicWanIpsecTunnel#bgp}.</summary>
        [JsiiProperty(name: "bgp", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelBgp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelBgp? Bgp
        {
            get
            {
                return null;
            }
        }

        /// <summary>The IP address assigned to the customer side of the IPsec tunnel.</summary>
        /// <remarks>
        /// Not required, but must be set for proactive traceroutes to work.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#customer_endpoint MagicWanIpsecTunnel#customer_endpoint}
        /// </remarks>
        [JsiiProperty(name: "customerEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#custom_remote_identities MagicWanIpsecTunnel#custom_remote_identities}.</summary>
        [JsiiProperty(name: "customRemoteIdentities", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelCustomRemoteIdentities\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelCustomRemoteIdentities? CustomRemoteIdentities
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional description forthe IPsec tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#description MagicWanIpsecTunnel#description}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#health_check MagicWanIpsecTunnel#health_check}.</summary>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelHealthCheck? HealthCheck
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#interface_address6 MagicWanIpsecTunnel#interface_address6}
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

        /// <summary>A randomly generated or provided string for use in the IPsec tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#psk MagicWanIpsecTunnel#psk}
        /// </remarks>
        [JsiiProperty(name: "psk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Psk
        {
            get
            {
                return null;
            }
        }

        /// <summary>If `true`, then IPsec replay protection will be supported in the Cloudflare-to-customer direction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#replay_protection MagicWanIpsecTunnel#replay_protection}
        /// </remarks>
        [JsiiProperty(name: "replayProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReplayProtection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicWanIpsecTunnelConfig), fullyQualifiedName: "cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#account_id MagicWanIpsecTunnel#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The IP address assigned to the Cloudflare side of the IPsec tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#cloudflare_endpoint MagicWanIpsecTunnel#cloudflare_endpoint}
            /// </remarks>
            [JsiiProperty(name: "cloudflareEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudflareEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel.</summary>
            /// <remarks>
            /// Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#interface_address MagicWanIpsecTunnel#interface_address}
            /// </remarks>
            [JsiiProperty(name: "interfaceAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string InterfaceAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the IPsec tunnel. The name cannot share a name with other tunnels.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#name MagicWanIpsecTunnel#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>True if automatic stateful return routing should be enabled for a tunnel, false otherwise.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#automatic_return_routing MagicWanIpsecTunnel#automatic_return_routing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automaticReturnRouting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutomaticReturnRouting
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#bgp MagicWanIpsecTunnel#bgp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bgp", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelBgp\"}", isOptional: true)]
            public cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelBgp? Bgp
            {
                get => GetInstanceProperty<cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelBgp?>();
            }

            /// <summary>The IP address assigned to the customer side of the IPsec tunnel.</summary>
            /// <remarks>
            /// Not required, but must be set for proactive traceroutes to work.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#customer_endpoint MagicWanIpsecTunnel#customer_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#custom_remote_identities MagicWanIpsecTunnel#custom_remote_identities}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customRemoteIdentities", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelCustomRemoteIdentities\"}", isOptional: true)]
            public cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelCustomRemoteIdentities? CustomRemoteIdentities
            {
                get => GetInstanceProperty<cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelCustomRemoteIdentities?>();
            }

            /// <summary>An optional description forthe IPsec tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#description MagicWanIpsecTunnel#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#health_check MagicWanIpsecTunnel#health_check}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelHealthCheck\"}", isOptional: true)]
            public cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelHealthCheck? HealthCheck
            {
                get => GetInstanceProperty<cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelHealthCheck?>();
            }

            /// <summary>A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6.</summary>
            /// <remarks>
            /// Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#interface_address6 MagicWanIpsecTunnel#interface_address6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interfaceAddress6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InterfaceAddress6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A randomly generated or provided string for use in the IPsec tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#psk MagicWanIpsecTunnel#psk}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "psk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Psk
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If `true`, then IPsec replay protection will be supported in the Cloudflare-to-customer direction.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_wan_ipsec_tunnel#replay_protection MagicWanIpsecTunnel#replay_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replayProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ReplayProtection
            {
                get => GetInstanceProperty<object?>();
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
