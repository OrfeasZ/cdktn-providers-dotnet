using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWebAnalyticsSite
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareWebAnalyticsSite.DataCloudflareWebAnalyticsSiteFilter")]
    public class DataCloudflareWebAnalyticsSiteFilter : cloudflare.DataCloudflareWebAnalyticsSite.IDataCloudflareWebAnalyticsSiteFilter
    {
        /// <summary>The property used to sort the list of results. Available values: "host", "created".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/web_analytics_site#order_by DataCloudflareWebAnalyticsSite#order_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrderBy
        {
            get;
            set;
        }
    }
}
