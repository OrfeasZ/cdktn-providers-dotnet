using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiGateway
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareAiGatewayFilter), fullyQualifiedName: "cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayFilter")]
    public interface IDataCloudflareAiGatewayFilter
    {
        /// <summary>Search by id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/ai_gateway#search DataCloudflareAiGateway#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareAiGatewayFilter), fullyQualifiedName: "cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareAiGateway.IDataCloudflareAiGatewayFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Search by id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/ai_gateway#search DataCloudflareAiGateway#search}
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
