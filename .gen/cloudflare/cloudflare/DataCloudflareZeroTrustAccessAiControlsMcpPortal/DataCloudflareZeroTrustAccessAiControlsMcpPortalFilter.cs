using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortal
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpPortal.DataCloudflareZeroTrustAccessAiControlsMcpPortalFilter")]
    public class DataCloudflareZeroTrustAccessAiControlsMcpPortalFilter : cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortal.IDataCloudflareZeroTrustAccessAiControlsMcpPortalFilter
    {
        /// <summary>Search by id, name, hostname.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_ai_controls_mcp_portal#search DataCloudflareZeroTrustAccessAiControlsMcpPortal#search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Search
        {
            get;
            set;
        }
    }
}
