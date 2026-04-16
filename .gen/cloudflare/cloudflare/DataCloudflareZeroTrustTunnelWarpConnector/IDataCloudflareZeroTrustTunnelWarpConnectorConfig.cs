using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustTunnelWarpConnector
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustTunnelWarpConnectorConfig), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorConfig")]
    public interface IDataCloudflareZeroTrustTunnelWarpConnectorConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Cloudflare account ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_warp_connector#account_id DataCloudflareZeroTrustTunnelWarpConnector#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_warp_connector#filter DataCloudflareZeroTrustTunnelWarpConnector#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.IDataCloudflareZeroTrustTunnelWarpConnectorFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>UUID of the tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_warp_connector#tunnel_id DataCloudflareZeroTrustTunnelWarpConnector#tunnel_id}
        /// </remarks>
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TunnelId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustTunnelWarpConnectorConfig), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.IDataCloudflareZeroTrustTunnelWarpConnectorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Cloudflare account ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_warp_connector#account_id DataCloudflareZeroTrustTunnelWarpConnector#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_warp_connector#filter DataCloudflareZeroTrustTunnelWarpConnector#filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorFilter\"}", isOptional: true)]
            public cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.IDataCloudflareZeroTrustTunnelWarpConnectorFilter? Filter
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.IDataCloudflareZeroTrustTunnelWarpConnectorFilter?>();
            }

            /// <summary>UUID of the tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_warp_connector#tunnel_id DataCloudflareZeroTrustTunnelWarpConnector#tunnel_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TunnelId
            {
                get => GetInstanceProperty<string?>();
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
