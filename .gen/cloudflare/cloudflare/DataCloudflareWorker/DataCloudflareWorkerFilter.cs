using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorker
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareWorker.DataCloudflareWorkerFilter")]
    public class DataCloudflareWorkerFilter : cloudflare.DataCloudflareWorker.IDataCloudflareWorkerFilter
    {
        /// <summary>Sort direction. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/worker#order DataCloudflareWorker#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Order
        {
            get;
            set;
        }

        /// <summary>Property to sort results by. Available values: "deployed_on", "updated_on", "created_on", "name".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/worker#order_by DataCloudflareWorker#order_by}
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
