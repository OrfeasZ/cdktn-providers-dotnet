using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBase
{
    [JsiiByValue(fqn: "digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesWebCrawlerDataSource")]
    public class GradientaiKnowledgeBaseDatasourcesWebCrawlerDataSource : digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesWebCrawlerDataSource
    {
        /// <summary>The base URL to crawl.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#base_url GradientaiKnowledgeBase#base_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseUrl
        {
            get;
            set;
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#crawling_option GradientaiKnowledgeBase#crawling_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crawlingOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrawlingOption
        {
            get;
            set;
        }

        private object? _embedMedia;

        /// <summary>Whether to embed media content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#embed_media GradientaiKnowledgeBase#embed_media}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "embedMedia", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EmbedMedia
        {
            get => _embedMedia;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _embedMedia = value;
            }
        }
    }
}
