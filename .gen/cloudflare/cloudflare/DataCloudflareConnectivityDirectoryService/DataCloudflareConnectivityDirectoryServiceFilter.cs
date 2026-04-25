using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareConnectivityDirectoryService
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareConnectivityDirectoryService.DataCloudflareConnectivityDirectoryServiceFilter")]
    public class DataCloudflareConnectivityDirectoryServiceFilter : cloudflare.DataCloudflareConnectivityDirectoryService.IDataCloudflareConnectivityDirectoryServiceFilter
    {
        /// <summary>Available values: "tcp", "http".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/connectivity_directory_service#type DataCloudflareConnectivityDirectoryService#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
