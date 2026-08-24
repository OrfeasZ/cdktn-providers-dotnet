using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceFilter")]
    public class DataCloudflareAiSearchInstanceFilter : cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceFilter
    {
        /// <summary>Filter by namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/ai_search_instance#namespace DataCloudflareAiSearchInstance#namespace}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Field to order results by. Available values: "created_at".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/ai_search_instance#order_by DataCloudflareAiSearchInstance#order_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrderBy
        {
            get;
            set;
        }

        /// <summary>Order direction. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/ai_search_instance#order_by_direction DataCloudflareAiSearchInstance#order_by_direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orderByDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrderByDirection
        {
            get;
            set;
        }

        /// <summary>Filter instances whose id contains this string (case-insensitive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/ai_search_instance#search DataCloudflareAiSearchInstance#search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Search
        {
            get;
            set;
        }
    }
}
