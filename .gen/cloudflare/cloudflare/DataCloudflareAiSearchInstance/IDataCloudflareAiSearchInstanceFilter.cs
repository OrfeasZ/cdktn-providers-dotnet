using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareAiSearchInstanceFilter), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceFilter")]
    public interface IDataCloudflareAiSearchInstanceFilter
    {
        /// <summary>Search by id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/ai_search_instance#search DataCloudflareAiSearchInstance#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareAiSearchInstanceFilter), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Search by id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/ai_search_instance#search DataCloudflareAiSearchInstance#search}
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
