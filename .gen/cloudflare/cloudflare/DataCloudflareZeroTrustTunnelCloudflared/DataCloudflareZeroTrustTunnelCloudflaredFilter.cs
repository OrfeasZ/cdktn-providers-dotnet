using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustTunnelCloudflared
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustTunnelCloudflared.DataCloudflareZeroTrustTunnelCloudflaredFilter")]
    public class DataCloudflareZeroTrustTunnelCloudflaredFilter : cloudflare.DataCloudflareZeroTrustTunnelCloudflared.IDataCloudflareZeroTrustTunnelCloudflaredFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared#exclude_prefix DataCloudflareZeroTrustTunnelCloudflared#exclude_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExcludePrefix
        {
            get;
            set;
        }

        /// <summary>If provided, include only resources that were created (and not deleted) before this time. URL encoded.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared#existed_at DataCloudflareZeroTrustTunnelCloudflared#existed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "existedAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExistedAt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared#include_prefix DataCloudflareZeroTrustTunnelCloudflared#include_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IncludePrefix
        {
            get;
            set;
        }

        private object? _isDeleted;

        /// <summary>If `true`, only include deleted tunnels. If `false`, exclude deleted tunnels. If empty, all tunnels will be included.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared#is_deleted DataCloudflareZeroTrustTunnelCloudflared#is_deleted}
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

        /// <summary>A user-friendly name for a tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared#name DataCloudflareZeroTrustTunnelCloudflared#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>The status of the tunnel.</summary>
        /// <remarks>
        /// Valid values are <c>inactive</c> (tunnel has never been run), <c>degraded</c> (tunnel is active and able to serve traffic but in an unhealthy state), <c>healthy</c> (tunnel is active and able to serve traffic), or <c>down</c> (tunnel can not serve traffic as it has no connections to the Cloudflare Edge).
        /// Available values: "inactive", "degraded", "healthy", "down".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared#status DataCloudflareZeroTrustTunnelCloudflared#status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>UUID of the tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared#uuid DataCloudflareZeroTrustTunnelCloudflared#uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared#was_active_at DataCloudflareZeroTrustTunnelCloudflared#was_active_at}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "wasActiveAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WasActiveAt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_cloudflared#was_inactive_at DataCloudflareZeroTrustTunnelCloudflared#was_inactive_at}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "wasInactiveAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WasInactiveAt
        {
            get;
            set;
        }
    }
}
