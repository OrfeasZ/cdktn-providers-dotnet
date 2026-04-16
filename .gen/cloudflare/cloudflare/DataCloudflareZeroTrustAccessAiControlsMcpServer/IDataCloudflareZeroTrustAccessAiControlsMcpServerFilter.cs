using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustAccessAiControlsMcpServerFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerFilter")]
    public interface IDataCloudflareZeroTrustAccessAiControlsMcpServerFilter
    {
        /// <summary>Search by id, name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_ai_controls_mcp_server#search DataCloudflareZeroTrustAccessAiControlsMcpServer#search}
        /// </remarks>
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Search
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustAccessAiControlsMcpServerFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer.IDataCloudflareZeroTrustAccessAiControlsMcpServerFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Search by id, name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_ai_controls_mcp_server#search DataCloudflareZeroTrustAccessAiControlsMcpServer#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
