using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions")]
    public class AiSearchInstanceSourceParamsWebCrawlerParseOptions : cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#include_headers AiSearchInstance#include_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? IncludeHeaders
        {
            get;
            set;
        }

        private object? _includeImages;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#include_images AiSearchInstance#include_images}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeImages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeImages
        {
            get => _includeImages;
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
                _includeImages = value;
            }
        }

        /// <summary>List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#specific_sitemaps AiSearchInstance#specific_sitemaps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "specificSitemaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SpecificSitemaps
        {
            get;
            set;
        }

        private object? _useBrowserRendering;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#use_browser_rendering AiSearchInstance#use_browser_rendering}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useBrowserRendering", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseBrowserRendering
        {
            get => _useBrowserRendering;
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
                _useBrowserRendering = value;
            }
        }
    }
}
