using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptions")]
    public class AiSearchInstanceSourceParamsWebCrawlerStoreOptions : cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#storage_id AiSearchInstance#storage_id}.</summary>
        [JsiiProperty(name: "storageId", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#r2_jurisdiction AiSearchInstance#r2_jurisdiction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "r2Jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? R2Jurisdiction
        {
            get;
            set;
        }

        /// <summary>Available values: "r2".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#storage_type AiSearchInstance#storage_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageType
        {
            get;
            set;
        }
    }
}
