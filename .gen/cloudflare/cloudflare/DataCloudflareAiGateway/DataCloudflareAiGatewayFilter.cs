using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiGateway
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayFilter")]
    public class DataCloudflareAiGatewayFilter : cloudflare.DataCloudflareAiGateway.IDataCloudflareAiGatewayFilter
    {
        /// <summary>Search by id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/ai_gateway#search DataCloudflareAiGateway#search}
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
