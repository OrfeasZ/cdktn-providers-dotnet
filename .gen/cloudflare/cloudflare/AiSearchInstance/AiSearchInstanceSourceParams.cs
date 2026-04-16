using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParams")]
    public class AiSearchInstanceSourceParams : cloudflare.AiSearchInstance.IAiSearchInstanceSourceParams
    {
        /// <summary>List of path patterns to exclude.</summary>
        /// <remarks>
        /// Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#exclude_items AiSearchInstance#exclude_items}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludeItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludeItems
        {
            get;
            set;
        }

        /// <summary>List of path patterns to include.</summary>
        /// <remarks>
        /// Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#include_items AiSearchInstance#include_items}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includeItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludeItems
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#prefix AiSearchInstance#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#r2_jurisdiction AiSearchInstance#r2_jurisdiction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "r2Jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? R2Jurisdiction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#web_crawler AiSearchInstance#web_crawler}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webCrawler", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler? WebCrawler
        {
            get;
            set;
        }
    }
}
