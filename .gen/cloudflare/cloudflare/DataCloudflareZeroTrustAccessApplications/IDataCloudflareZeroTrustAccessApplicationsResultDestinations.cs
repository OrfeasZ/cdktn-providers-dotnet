using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplications
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustAccessApplicationsResultDestinations), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultDestinations")]
    public interface IDataCloudflareZeroTrustAccessApplicationsResultDestinations
    {
        /// <summary>A MCP server id configured in ai-controls. Access will secure the MCP server if accessed through a MCP portal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_access_applications#mcp_server_id DataCloudflareZeroTrustAccessApplications#mcp_server_id}
        /// </remarks>
        [JsiiProperty(name: "mcpServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? McpServerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustAccessApplicationsResultDestinations), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultDestinations")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultDestinations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A MCP server id configured in ai-controls. Access will secure the MCP server if accessed through a MCP portal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_access_applications#mcp_server_id DataCloudflareZeroTrustAccessApplications#mcp_server_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mcpServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? McpServerId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
