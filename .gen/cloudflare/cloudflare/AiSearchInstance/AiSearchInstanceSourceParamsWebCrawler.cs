using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler")]
    public class AiSearchInstanceSourceParamsWebCrawler : cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler
    {
        /// <summary>Options for parse_type 'discover', where Browser Run discovers URLs by link following and sitemaps. Ignored for 'sitemap'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#discover_options AiSearchInstance#discover_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "discoverOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerDiscoverOptions\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerDiscoverOptions? DiscoverOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#parse_options AiSearchInstance#parse_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parseOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions? ParseOptions
        {
            get;
            set;
        }

        /// <summary>How URLs are discovered.</summary>
        /// <remarks>
        /// 'sitemap' reads XML sitemaps; 'discover' follows links recursively and requires the source to be a Verified zone on this account.
        /// Available values: "sitemap", "discover".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#parse_type AiSearchInstance#parse_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParseType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#store_options AiSearchInstance#store_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storeOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptions\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions? StoreOptions
        {
            get;
            set;
        }
    }
}
