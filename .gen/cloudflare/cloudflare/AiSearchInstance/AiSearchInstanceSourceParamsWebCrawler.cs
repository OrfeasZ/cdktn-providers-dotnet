using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler")]
    public class AiSearchInstanceSourceParamsWebCrawler : cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#parse_options AiSearchInstance#parse_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parseOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions? ParseOptions
        {
            get;
            set;
        }

        /// <summary>Available values: "sitemap", "feed-rss".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#parse_type AiSearchInstance#parse_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParseType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#store_options AiSearchInstance#store_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storeOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptions\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions? StoreOptions
        {
            get;
            set;
        }
    }
}
