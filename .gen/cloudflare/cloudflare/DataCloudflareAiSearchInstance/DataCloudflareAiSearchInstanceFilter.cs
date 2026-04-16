using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceFilter")]
    public class DataCloudflareAiSearchInstanceFilter : cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceFilter
    {
        /// <summary>Search by id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/ai_search_instance#search DataCloudflareAiSearchInstance#search}
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
