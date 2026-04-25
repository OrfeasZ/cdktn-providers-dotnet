using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawler), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler")]
    public interface IAiSearchInstanceSourceParamsWebCrawler
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#crawl_options AiSearchInstance#crawl_options}.</summary>
        [JsiiProperty(name: "crawlOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerCrawlOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerCrawlOptions? CrawlOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#parse_options AiSearchInstance#parse_options}.</summary>
        [JsiiProperty(name: "parseOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions? ParseOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "sitemap", "feed-rss", "crawl".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#parse_type AiSearchInstance#parse_type}
        /// </remarks>
        [JsiiProperty(name: "parseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParseType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#store_options AiSearchInstance#store_options}.</summary>
        [JsiiProperty(name: "storeOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions? StoreOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawler), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#crawl_options AiSearchInstance#crawl_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crawlOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerCrawlOptions\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerCrawlOptions? CrawlOptions
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerCrawlOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#parse_options AiSearchInstance#parse_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parseOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions? ParseOptions
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions?>();
            }

            /// <summary>Available values: "sitemap", "feed-rss", "crawl".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#parse_type AiSearchInstance#parse_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParseType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#store_options AiSearchInstance#store_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storeOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptions\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions? StoreOptions
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions?>();
            }
        }
    }
}
