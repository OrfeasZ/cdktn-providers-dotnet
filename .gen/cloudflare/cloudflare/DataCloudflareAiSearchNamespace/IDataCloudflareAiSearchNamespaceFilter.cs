using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchNamespace
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareAiSearchNamespaceFilter), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespaceFilter")]
    public interface IDataCloudflareAiSearchNamespaceFilter
    {
        /// <summary>Filter namespaces whose name or description contains this string (case-insensitive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/ai_search_namespace#search DataCloudflareAiSearchNamespace#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareAiSearchNamespaceFilter), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespaceFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareAiSearchNamespace.IDataCloudflareAiSearchNamespaceFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter namespaces whose name or description contains this string (case-insensitive).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/ai_search_namespace#search DataCloudflareAiSearchNamespace#search}
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
