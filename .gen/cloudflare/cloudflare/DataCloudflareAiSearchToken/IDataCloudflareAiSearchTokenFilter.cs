using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchToken
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareAiSearchTokenFilter), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchToken.DataCloudflareAiSearchTokenFilter")]
    public interface IDataCloudflareAiSearchTokenFilter
    {
        /// <summary>Filter tokens whose name contains this string (case-insensitive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/ai_search_token#search DataCloudflareAiSearchToken#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareAiSearchTokenFilter), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchToken.DataCloudflareAiSearchTokenFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareAiSearchToken.IDataCloudflareAiSearchTokenFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter tokens whose name contains this string (case-insensitive).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/ai_search_token#search DataCloudflareAiSearchToken#search}
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
