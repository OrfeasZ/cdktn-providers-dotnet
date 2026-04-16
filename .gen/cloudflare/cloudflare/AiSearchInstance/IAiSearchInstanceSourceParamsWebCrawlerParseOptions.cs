using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawlerParseOptions), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions")]
    public interface IAiSearchInstanceSourceParamsWebCrawlerParseOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#include_headers AiSearchInstance#include_headers}.</summary>
        [JsiiProperty(name: "includeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? IncludeHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#include_images AiSearchInstance#include_images}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#specific_sitemaps AiSearchInstance#specific_sitemaps}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#use_browser_rendering AiSearchInstance#use_browser_rendering}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#include_headers AiSearchInstance#include_headers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? IncludeHeaders
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#include_images AiSearchInstance#include_images}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeImages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeImages
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#specific_sitemaps AiSearchInstance#specific_sitemaps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "specificSitemaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SpecificSitemaps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#use_browser_rendering AiSearchInstance#use_browser_rendering}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useBrowserRendering", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseBrowserRendering
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
