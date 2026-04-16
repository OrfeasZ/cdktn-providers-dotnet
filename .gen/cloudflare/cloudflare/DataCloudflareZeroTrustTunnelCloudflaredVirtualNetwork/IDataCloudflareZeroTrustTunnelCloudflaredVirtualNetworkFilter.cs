using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustTunnelCloudflaredVirtualNetworkFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork.DataCloudflareZeroTrustTunnelCloudflaredVirtualNetworkFilter")]
    public interface IDataCloudflareZeroTrustTunnelCloudflaredVirtualNetworkFilter
    {
        /// <summary>UUID of the virtual network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared_virtual_network#id DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork#id}
        ///
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

        /// <summary>If `true`, only include the default virtual network.</summary>
        /// <remarks>
        /// If <c>false</c>, exclude the default virtual network. If empty, all virtual networks will be included.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared_virtual_network#is_default DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork#is_default}
        /// </remarks>
        [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDefault
        {
            get
            {
                return null;
            }
        }

        /// <summary>If `true`, only include the default virtual network.</summary>
        /// <remarks>
        /// If <c>false</c>, exclude the default virtual network. If empty, all virtual networks will be included.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared_virtual_network#is_default_network DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork#is_default_network}
        /// </remarks>
        [JsiiProperty(name: "isDefaultNetwork", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDefaultNetwork
        {
            get
            {
                return null;
            }
        }

        /// <summary>If `true`, only include deleted virtual networks.</summary>
        /// <remarks>
        /// If <c>false</c>, exclude deleted virtual networks. If empty, all virtual networks will be included.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared_virtual_network#is_deleted DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork#is_deleted}
        /// </remarks>
        [JsiiProperty(name: "isDeleted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDeleted
        {
            get
            {
                return null;
            }
        }

        /// <summary>A user-friendly name for the virtual network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared_virtual_network#name DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustTunnelCloudflaredVirtualNetworkFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork.DataCloudflareZeroTrustTunnelCloudflaredVirtualNetworkFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork.IDataCloudflareZeroTrustTunnelCloudflaredVirtualNetworkFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UUID of the virtual network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared_virtual_network#id DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If `true`, only include the default virtual network.</summary>
            /// <remarks>
            /// If <c>false</c>, exclude the default virtual network. If empty, all virtual networks will be included.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared_virtual_network#is_default DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork#is_default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDefault
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If `true`, only include the default virtual network.</summary>
            /// <remarks>
            /// If <c>false</c>, exclude the default virtual network. If empty, all virtual networks will be included.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared_virtual_network#is_default_network DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork#is_default_network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDefaultNetwork", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDefaultNetwork
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If `true`, only include deleted virtual networks.</summary>
            /// <remarks>
            /// If <c>false</c>, exclude deleted virtual networks. If empty, all virtual networks will be included.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared_virtual_network#is_deleted DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork#is_deleted}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDeleted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDeleted
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A user-friendly name for the virtual network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared_virtual_network#name DataCloudflareZeroTrustTunnelCloudflaredVirtualNetwork#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
