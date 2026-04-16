using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustNetworkHostnameRoute
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustNetworkHostnameRoute.DataCloudflareZeroTrustNetworkHostnameRouteFilter")]
    public class DataCloudflareZeroTrustNetworkHostnameRouteFilter : cloudflare.DataCloudflareZeroTrustNetworkHostnameRoute.IDataCloudflareZeroTrustNetworkHostnameRouteFilter
    {
        /// <summary>If set, only list hostname routes with the given comment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_network_hostname_route#comment DataCloudflareZeroTrustNetworkHostnameRoute#comment}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_network_hostname_route#existed_at DataCloudflareZeroTrustNetworkHostnameRoute#existed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "existedAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExistedAt
        {
            get;
            set;
        }

        /// <summary>If set, only list hostname routes that contain a substring of the given value, the filter is case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_network_hostname_route#hostname DataCloudflareZeroTrustNetworkHostnameRoute#hostname}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }

        /// <summary>The hostname route ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_network_hostname_route#id DataCloudflareZeroTrustNetworkHostnameRoute#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        private object? _isDeleted;

        /// <summary>If `true`, only return deleted hostname routes. If `false`, exclude deleted hostname routes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_network_hostname_route#is_deleted DataCloudflareZeroTrustNetworkHostnameRoute#is_deleted}
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

        /// <summary>If set, only list hostname routes that point to a specific tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_network_hostname_route#tunnel_id DataCloudflareZeroTrustNetworkHostnameRoute#tunnel_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TunnelId
        {
            get;
            set;
        }
    }
}
