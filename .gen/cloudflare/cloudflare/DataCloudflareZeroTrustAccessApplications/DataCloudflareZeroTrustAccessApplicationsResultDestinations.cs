using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplications
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultDestinations")]
    public class DataCloudflareZeroTrustAccessApplicationsResultDestinations : cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultDestinations
    {
        /// <summary>A MCP server id configured in ai-controls. Access will secure the MCP server if accessed through a MCP portal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_applications#mcp_server_id DataCloudflareZeroTrustAccessApplications#mcp_server_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mcpServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? McpServerId
        {
            get;
            set;
        }
    }
}
