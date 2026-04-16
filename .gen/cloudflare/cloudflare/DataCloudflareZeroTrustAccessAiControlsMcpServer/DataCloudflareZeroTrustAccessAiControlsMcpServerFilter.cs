using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerFilter")]
    public class DataCloudflareZeroTrustAccessAiControlsMcpServerFilter : cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer.IDataCloudflareZeroTrustAccessAiControlsMcpServerFilter
    {
        /// <summary>Search by id, name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_ai_controls_mcp_server#search DataCloudflareZeroTrustAccessAiControlsMcpServer#search}
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
