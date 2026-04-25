using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceSourceParams), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParams")]
    public interface IAiSearchInstanceSourceParams
    {
        /// <summary>List of path patterns to exclude.</summary>
        /// <remarks>
        /// Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#exclude_items AiSearchInstance#exclude_items}
        /// </remarks>
        [JsiiProperty(name: "excludeItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludeItems
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of path patterns to include.</summary>
        /// <remarks>
        /// Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#include_items AiSearchInstance#include_items}
        /// </remarks>
        [JsiiProperty(name: "includeItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludeItems
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#prefix AiSearchInstance#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#r2_jurisdiction AiSearchInstance#r2_jurisdiction}.</summary>
        [JsiiProperty(name: "r2Jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? R2Jurisdiction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#web_crawler AiSearchInstance#web_crawler}.</summary>
        [JsiiProperty(name: "webCrawler", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler? WebCrawler
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceSourceParams), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParams")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceSourceParams
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of path patterns to exclude.</summary>
            /// <remarks>
            /// Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#exclude_items AiSearchInstance#exclude_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludeItems
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of path patterns to include.</summary>
            /// <remarks>
            /// Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#include_items AiSearchInstance#include_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludeItems
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#prefix AiSearchInstance#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#r2_jurisdiction AiSearchInstance#r2_jurisdiction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "r2Jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? R2Jurisdiction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#web_crawler AiSearchInstance#web_crawler}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webCrawler", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler? WebCrawler
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler?>();
            }
        }
    }
}
