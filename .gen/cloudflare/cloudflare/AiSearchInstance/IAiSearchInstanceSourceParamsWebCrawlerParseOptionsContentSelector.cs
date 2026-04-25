using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector")]
    public interface IAiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector
    {
        /// <summary>Glob pattern to match against the page URL path.</summary>
        /// <remarks>
        /// Uses standard glob syntax: * matches within a segment, ** crosses directories.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#path AiSearchInstance#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>CSS selector to extract content from pages matching the path pattern.</summary>
        /// <remarks>
        /// Supports standard CSS selectors including class, ID, element, and attribute selectors.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#selector AiSearchInstance#selector}
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}")]
        string Selector
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Glob pattern to match against the page URL path.</summary>
            /// <remarks>
            /// Uses standard glob syntax: * matches within a segment, ** crosses directories.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#path AiSearchInstance#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>CSS selector to extract content from pages matching the path pattern.</summary>
            /// <remarks>
            /// Supports standard CSS selectors including class, ID, element, and attribute selectors.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#selector AiSearchInstance#selector}
            /// </remarks>
            [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}")]
            public string Selector
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
