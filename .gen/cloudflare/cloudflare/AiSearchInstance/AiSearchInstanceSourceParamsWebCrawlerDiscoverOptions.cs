using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerDiscoverOptions")]
    public class AiSearchInstanceSourceParamsWebCrawlerDiscoverOptions : cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerDiscoverOptions
    {
        /// <summary>Maximum link-follow depth from the seed URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#depth AiSearchInstance#depth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "depth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Depth
        {
            get;
            set;
        }

        private object? _includeExternalLinks;

        /// <summary>Follow links that point outside the source domain.</summary>
        /// <remarks>
        /// Must stay <c>false</c> — discover crawls are restricted to the zone you own.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#include_external_links AiSearchInstance#include_external_links}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includeExternalLinks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeExternalLinks
        {
            get => _includeExternalLinks;
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
                _includeExternalLinks = value;
            }
        }

        private object? _includeSubdomains;

        /// <summary>Follow links to subdomains of the source host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#include_subdomains AiSearchInstance#include_subdomains}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includeSubdomains", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeSubdomains
        {
            get => _includeSubdomains;
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
                _includeSubdomains = value;
            }
        }

        /// <summary>Maximum number of pages to crawl (1-100000).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#limit AiSearchInstance#limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Limit
        {
            get;
            set;
        }

        /// <summary>Maximum content age in seconds to accept (0–604800).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#max_age AiSearchInstance#max_age}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAge
        {
            get;
            set;
        }

        /// <summary>Where the crawler looks for URLs: 'sitemaps' reads sitemap XML only, 'links' follows page links only, 'all' does both.</summary>
        /// <remarks>
        /// Available values: "all", "sitemaps", "links".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#source AiSearchInstance#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }
    }
}
