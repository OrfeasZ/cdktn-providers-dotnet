using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawlerStoreOptions), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptions")]
    public interface IAiSearchInstanceSourceParamsWebCrawlerStoreOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#storage_id AiSearchInstance#storage_id}.</summary>
        [JsiiProperty(name: "storageId", typeJson: "{\"primitive\":\"string\"}")]
        string StorageId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#r2_jurisdiction AiSearchInstance#r2_jurisdiction}.</summary>
        [JsiiProperty(name: "r2Jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? R2Jurisdiction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "r2".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#storage_type AiSearchInstance#storage_type}
        /// </remarks>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawlerStoreOptions), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#storage_id AiSearchInstance#storage_id}.</summary>
            [JsiiProperty(name: "storageId", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#r2_jurisdiction AiSearchInstance#r2_jurisdiction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "r2Jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? R2Jurisdiction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Available values: "r2".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#storage_type AiSearchInstance#storage_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
