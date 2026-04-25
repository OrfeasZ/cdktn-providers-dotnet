using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkflow
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareWorkflow.DataCloudflareWorkflowFilter")]
    public class DataCloudflareWorkflowFilter : cloudflare.DataCloudflareWorkflow.IDataCloudflareWorkflowFilter
    {
        /// <summary>Allows filtering workflows` name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/workflow#search DataCloudflareWorkflow#search}
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
