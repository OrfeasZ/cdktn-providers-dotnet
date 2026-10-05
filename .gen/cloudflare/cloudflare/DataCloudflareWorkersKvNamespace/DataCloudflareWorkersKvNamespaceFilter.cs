using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkersKvNamespace
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareWorkersKvNamespace.DataCloudflareWorkersKvNamespaceFilter")]
    public class DataCloudflareWorkersKvNamespaceFilter : cloudflare.DataCloudflareWorkersKvNamespace.IDataCloudflareWorkersKvNamespaceFilter
    {
        /// <summary>Sort namespaces in ascending (`asc`) or descending (`desc`) order. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/workers_kv_namespace#direction DataCloudflareWorkersKvNamespace#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>Namespace field to sort by (`id` or `title`). Available values: "id", "title".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/workers_kv_namespace#order DataCloudflareWorkersKvNamespace#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Order
        {
            get;
            set;
        }
    }
}
