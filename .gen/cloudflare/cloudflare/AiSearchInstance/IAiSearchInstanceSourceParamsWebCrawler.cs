using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawler), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler")]
    public interface IAiSearchInstanceSourceParamsWebCrawler
    {
        /// <summary>Options for parse_type 'discover', where Browser Run discovers URLs by link following and sitemaps. Ignored for 'sitemap'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#discover_options AiSearchInstance#discover_options}
        /// </remarks>
        [JsiiProperty(name: "discoverOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerDiscoverOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerDiscoverOptions? DiscoverOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#parse_options AiSearchInstance#parse_options}.</summary>
        [JsiiProperty(name: "parseOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions? ParseOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>How URLs are discovered.</summary>
        /// <remarks>
        /// 'sitemap' reads XML sitemaps; 'discover' follows links recursively and requires the source to be a Verified zone on this account.
        /// Available values: "sitemap", "discover".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#parse_type AiSearchInstance#parse_type}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#store_options AiSearchInstance#store_options}.</summary>
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

            /// <summary>Options for parse_type 'discover', where Browser Run discovers URLs by link following and sitemaps. Ignored for 'sitemap'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#discover_options AiSearchInstance#discover_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discoverOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerDiscoverOptions\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerDiscoverOptions? DiscoverOptions
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerDiscoverOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#parse_options AiSearchInstance#parse_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parseOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions? ParseOptions
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#store_options AiSearchInstance#store_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storeOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptions\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions? StoreOptions
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions?>();
            }
        }
    }
}
