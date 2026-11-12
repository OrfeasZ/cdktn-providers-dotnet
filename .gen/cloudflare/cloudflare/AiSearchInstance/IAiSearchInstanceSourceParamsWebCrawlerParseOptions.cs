using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawlerParseOptions), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions")]
    public interface IAiSearchInstanceSourceParamsWebCrawlerParseOptions
    {
        /// <summary>List of path-to-selector mappings for extracting specific content from crawled pages.</summary>
        /// <remarks>
        /// Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. The crawler stores and indexes only the matched HTML fragment. Omit the field to disable content selection; the API rejects empty arrays.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_search_instance#content_selector AiSearchInstance#content_selector}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "contentSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ContentSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Up to 5 custom HTTP headers sent with each crawl request.</summary>
        /// <remarks>
        /// Names must use RFC-7230 token characters, excluding spaces, colons, and control characters. Values must use HTAB and printable ASCII only, excluding CR and LF.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_search_instance#include_headers AiSearchInstance#include_headers}
        /// </remarks>
        [JsiiProperty(name: "includeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? IncludeHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_search_instance#include_images AiSearchInstance#include_images}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "includeImages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeImages
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_search_instance#specific_sitemaps AiSearchInstance#specific_sitemaps}
        /// </remarks>
        [JsiiProperty(name: "specificSitemaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SpecificSitemaps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_search_instance#use_browser_rendering AiSearchInstance#use_browser_rendering}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useBrowserRendering", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseBrowserRendering
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawlerParseOptions), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of path-to-selector mappings for extracting specific content from crawled pages.</summary>
            /// <remarks>
            /// Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. The crawler stores and indexes only the matched HTML fragment. Omit the field to disable content selection; the API rejects empty arrays.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_search_instance#content_selector AiSearchInstance#content_selector}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ContentSelector
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Up to 5 custom HTTP headers sent with each crawl request.</summary>
            /// <remarks>
            /// Names must use RFC-7230 token characters, excluding spaces, colons, and control characters. Values must use HTAB and printable ASCII only, excluding CR and LF.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_search_instance#include_headers AiSearchInstance#include_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? IncludeHeaders
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_search_instance#include_images AiSearchInstance#include_images}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeImages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeImages
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_search_instance#specific_sitemaps AiSearchInstance#specific_sitemaps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "specificSitemaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SpecificSitemaps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/ai_search_instance#use_browser_rendering AiSearchInstance#use_browser_rendering}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useBrowserRendering", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseBrowserRendering
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
