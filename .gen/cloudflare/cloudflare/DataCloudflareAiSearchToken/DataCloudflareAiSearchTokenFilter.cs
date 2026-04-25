using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchToken
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareAiSearchToken.DataCloudflareAiSearchTokenFilter")]
    public class DataCloudflareAiSearchTokenFilter : cloudflare.DataCloudflareAiSearchToken.IDataCloudflareAiSearchTokenFilter
    {
        /// <summary>Filter tokens whose name contains this string (case-insensitive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/ai_search_token#search DataCloudflareAiSearchToken#search}
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
