using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomSsl
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareCustomSsl.DataCloudflareCustomSslFilter")]
    public class DataCloudflareCustomSslFilter : cloudflare.DataCloudflareCustomSsl.IDataCloudflareCustomSslFilter
    {
        /// <summary>Whether to match all search requirements or at least one (any). Available values: "any", "all".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_ssl#match DataCloudflareCustomSsl#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Match
        {
            get;
            set;
        }

        /// <summary>Status of the zone's custom SSL. Available values: "active", "expired", "deleted", "pending", "initializing".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_ssl#status DataCloudflareCustomSsl#status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
