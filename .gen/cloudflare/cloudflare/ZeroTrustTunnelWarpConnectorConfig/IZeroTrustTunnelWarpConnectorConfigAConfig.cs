using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelWarpConnectorConfig
{
    [JsiiInterface(nativeType: typeof(IZeroTrustTunnelWarpConnectorConfigAConfig), fullyQualifiedName: "cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigAConfig")]
    public interface IZeroTrustTunnelWarpConnectorConfigAConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_tunnel_warp_connector_config#account_id ZeroTrustTunnelWarpConnectorConfigA#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>High-availability mode for the WARP Connector tunnel.</summary>
        /// <remarks>
        /// <c>none</c> means HA is enabled but no provider is configured yet (newly created tunnels default to this). <c>disabled</c> means HA is explicitly turned off. <c>aws</c> uses AWS ENI move for failover. <c>local</c> uses virtual IPs (VIPs) on the local interface.
        /// Available values: "none", "disabled", "aws", "local".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_tunnel_warp_connector_config#ha_mode ZeroTrustTunnelWarpConnectorConfigA#ha_mode}
        /// </remarks>
        [JsiiProperty(name: "haMode", typeJson: "{\"primitive\":\"string\"}")]
        string HaMode
        {
            get;
        }

        /// <summary>UUID of the tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_tunnel_warp_connector_config#tunnel_id ZeroTrustTunnelWarpConnectorConfigA#tunnel_id}
        /// </remarks>
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
        string TunnelId
        {
            get;
        }

        /// <summary>Provider-specific configuration.</summary>
        /// <remarks>
        /// Required shape depends on ha_mode. For <c>aws</c>, must contain <c>fnr_id</c>. For <c>local</c>, must contain <c>vips</c>. For <c>none</c> and <c>disabled</c>, must be empty or omitted.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_tunnel_warp_connector_config#config ZeroTrustTunnelWarpConnectorConfigA#config}
        /// </remarks>
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigConfig? Config
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustTunnelWarpConnectorConfigAConfig), fullyQualifiedName: "cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigAConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigAConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_tunnel_warp_connector_config#account_id ZeroTrustTunnelWarpConnectorConfigA#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>High-availability mode for the WARP Connector tunnel.</summary>
            /// <remarks>
            /// <c>none</c> means HA is enabled but no provider is configured yet (newly created tunnels default to this). <c>disabled</c> means HA is explicitly turned off. <c>aws</c> uses AWS ENI move for failover. <c>local</c> uses virtual IPs (VIPs) on the local interface.
            /// Available values: "none", "disabled", "aws", "local".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_tunnel_warp_connector_config#ha_mode ZeroTrustTunnelWarpConnectorConfigA#ha_mode}
            /// </remarks>
            [JsiiProperty(name: "haMode", typeJson: "{\"primitive\":\"string\"}")]
            public string HaMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>UUID of the tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_tunnel_warp_connector_config#tunnel_id ZeroTrustTunnelWarpConnectorConfigA#tunnel_id}
            /// </remarks>
            [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
            public string TunnelId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Provider-specific configuration.</summary>
            /// <remarks>
            /// Required shape depends on ha_mode. For <c>aws</c>, must contain <c>fnr_id</c>. For <c>local</c>, must contain <c>vips</c>. For <c>none</c> and <c>disabled</c>, must be empty or omitted.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_tunnel_warp_connector_config#config ZeroTrustTunnelWarpConnectorConfigA#config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelWarpConnectorConfig.ZeroTrustTunnelWarpConnectorConfigConfig\"}", isOptional: true)]
            public cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigConfig? Config
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustTunnelWarpConnectorConfig.IZeroTrustTunnelWarpConnectorConfigConfig?>();
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
