using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawlerDiscoverOptions), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerDiscoverOptions")]
    public interface IAiSearchInstanceSourceParamsWebCrawlerDiscoverOptions
    {
        /// <summary>Maximum link-follow depth from the seed URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#depth AiSearchInstance#depth}
        /// </remarks>
        [JsiiProperty(name: "depth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Depth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Follow links that point outside the source domain.</summary>
        /// <remarks>
        /// Must stay <c>false</c> — discover crawls are restricted to the zone you own.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#include_external_links AiSearchInstance#include_external_links}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "includeExternalLinks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeExternalLinks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Follow links to subdomains of the source host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#include_subdomains AiSearchInstance#include_subdomains}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "includeSubdomains", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeSubdomains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum number of pages to crawl (1-100000).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#limit AiSearchInstance#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Limit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum content age in seconds to accept (0–604800).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#max_age AiSearchInstance#max_age}
        /// </remarks>
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Where the crawler looks for URLs: 'sitemaps' reads sitemap XML only, 'links' follows page links only, 'all' does both.</summary>
        /// <remarks>
        /// Available values: "all", "sitemaps", "links".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#source AiSearchInstance#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawlerDiscoverOptions), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerDiscoverOptions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerDiscoverOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Maximum link-follow depth from the seed URL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#depth AiSearchInstance#depth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "depth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Depth
            {
                get => GetInstanceProperty<double?>();
            }

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
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Follow links to subdomains of the source host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#include_subdomains AiSearchInstance#include_subdomains}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeSubdomains", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeSubdomains
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Maximum number of pages to crawl (1-100000).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#limit AiSearchInstance#limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Maximum content age in seconds to accept (0–604800).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_instance#max_age AiSearchInstance#max_age}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAge
            {
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
