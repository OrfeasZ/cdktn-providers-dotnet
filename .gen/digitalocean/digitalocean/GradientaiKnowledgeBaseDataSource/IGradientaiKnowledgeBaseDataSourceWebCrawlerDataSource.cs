using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBaseDataSource
{
    [JsiiInterface(nativeType: typeof(IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceWebCrawlerDataSource")]
    public interface IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource
    {
        /// <summary>The base URL to crawl.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source#base_url GradientaiKnowledgeBaseDataSource#base_url}
        /// </remarks>
        [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Options for specifying how URLs found on pages should be handled.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description>UNKNOWN: Default unknown value</description>
        /// <description>SCOPED: Only include the base URL.</description>
        /// <description>PATH: Crawl the base URL and linked pages within the URL path.</description>
        /// <description>DOMAIN: Crawl the base URL and linked pages within the same domain.</description>
        /// <description>SUBDOMAINS: Crawl the base URL and linked pages for any subdomain.</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source#crawling_option GradientaiKnowledgeBaseDataSource#crawling_option}
        /// </remarks>
        [JsiiProperty(name: "crawlingOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrawlingOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to embed media content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source#embed_media GradientaiKnowledgeBaseDataSource#embed_media}
        /// </remarks>
        [JsiiProperty(name: "embedMedia", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EmbedMedia
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceWebCrawlerDataSource")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The base URL to crawl.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source#base_url GradientaiKnowledgeBaseDataSource#base_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Options for specifying how URLs found on pages should be handled.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description>UNKNOWN: Default unknown value</description>
            /// <description>SCOPED: Only include the base URL.</description>
            /// <description>PATH: Crawl the base URL and linked pages within the URL path.</description>
            /// <description>DOMAIN: Crawl the base URL and linked pages within the same domain.</description>
            /// <description>SUBDOMAINS: Crawl the base URL and linked pages for any subdomain.</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source#crawling_option GradientaiKnowledgeBaseDataSource#crawling_option}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crawlingOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrawlingOption
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to embed media content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source#embed_media GradientaiKnowledgeBaseDataSource#embed_media}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "embedMedia", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EmbedMedia
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
