using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustAccessApplicationDestinations), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationDestinations")]
    public interface IDataCloudflareZeroTrustAccessApplicationDestinations
    {
        /// <summary>A MCP server id configured in ai-controls. Access will secure the MCP server if accessed through a MCP portal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#mcp_server_id DataCloudflareZeroTrustAccessApplication#mcp_server_id}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustAccessApplicationDestinations), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationDestinations")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationDestinations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A MCP server id configured in ai-controls. Access will secure the MCP server if accessed through a MCP portal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#mcp_server_id DataCloudflareZeroTrustAccessApplication#mcp_server_id}
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
