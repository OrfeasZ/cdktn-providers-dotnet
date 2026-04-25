using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustTunnelCloudflaredRoute
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustTunnelCloudflaredRoute.DataCloudflareZeroTrustTunnelCloudflaredRouteFilter")]
    public class DataCloudflareZeroTrustTunnelCloudflaredRouteFilter : cloudflare.DataCloudflareZeroTrustTunnelCloudflaredRoute.IDataCloudflareZeroTrustTunnelCloudflaredRouteFilter
    {
        /// <summary>Optional remark describing the route.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_tunnel_cloudflared_route#comment DataCloudflareZeroTrustTunnelCloudflaredRoute#comment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Comment
        {
            get;
            set;
        }

        /// <summary>If provided, include only resources that were created (and not deleted) before this time. URL encoded.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_tunnel_cloudflared_route#existed_at DataCloudflareZeroTrustTunnelCloudflaredRoute#existed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "existedAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExistedAt
        {
            get;
            set;
        }

        private object? _isDeleted;

        /// <summary>If `true`, only include deleted routes. If `false`, exclude deleted routes. If empty, all routes will be included.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_tunnel_cloudflared_route#is_deleted DataCloudflareZeroTrustTunnelCloudflaredRoute#is_deleted}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isDeleted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDeleted
        {
            get => _isDeleted;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isDeleted = value;
            }
        }

        /// <summary>If set, only list routes that are contained within this IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_tunnel_cloudflared_route#network_subset DataCloudflareZeroTrustTunnelCloudflaredRoute#network_subset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSubset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkSubset
        {
            get;
            set;
        }

        /// <summary>If set, only list routes that contain this IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_tunnel_cloudflared_route#network_superset DataCloudflareZeroTrustTunnelCloudflaredRoute#network_superset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSuperset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkSuperset
        {
            get;
            set;
        }

        /// <summary>UUID of the tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_tunnel_cloudflared_route#tunnel_id DataCloudflareZeroTrustTunnelCloudflaredRoute#tunnel_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TunnelId
        {
            get;
            set;
        }

        /// <summary>The types of tunnels to filter by, separated by commas.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_tunnel_cloudflared_route#tun_types DataCloudflareZeroTrustTunnelCloudflaredRoute#tun_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tunTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TunTypes
        {
            get;
            set;
        }

        /// <summary>UUID of the virtual network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_tunnel_cloudflared_route#virtual_network_id DataCloudflareZeroTrustTunnelCloudflaredRoute#virtual_network_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualNetworkId
        {
            get;
            set;
        }
    }
}
