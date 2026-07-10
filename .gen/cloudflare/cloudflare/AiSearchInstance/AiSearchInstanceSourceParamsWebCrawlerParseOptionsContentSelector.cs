using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector")]
    public class AiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector : cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptionsContentSelector
    {
        /// <summary>Glob pattern to match against the page URL path.</summary>
        /// <remarks>
        /// Uses standard glob syntax: * matches within a segment, ** crosses directories.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_search_instance#path AiSearchInstance#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>CSS selector to extract content from pages matching the path pattern.</summary>
        /// <remarks>
        /// Must not contain disallowed characters (;, `, $, {, }, ). Must target a single element; if multiple elements match, the selector is ignored and the full page is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_search_instance#selector AiSearchInstance#selector}
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}")]
        public string Selector
        {
            get;
            set;
        }
    }
}
