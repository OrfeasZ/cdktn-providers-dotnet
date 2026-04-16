using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkersScript
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareWorkersScript.DataCloudflareWorkersScriptFilter")]
    public class DataCloudflareWorkersScriptFilter : cloudflare.DataCloudflareWorkersScript.IDataCloudflareWorkersScriptFilter
    {
        /// <summary>Filter scripts by tags. Format: comma-separated list of tag:allowed pairs where allowed is 'yes' or 'no'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/workers_script#tags DataCloudflareWorkersScript#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tags
        {
            get;
            set;
        }
    }
}
