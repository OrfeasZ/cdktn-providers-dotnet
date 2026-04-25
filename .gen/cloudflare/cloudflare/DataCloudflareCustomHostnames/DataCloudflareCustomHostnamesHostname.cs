using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomHostnames
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesHostname")]
    public class DataCloudflareCustomHostnamesHostname : cloudflare.DataCloudflareCustomHostnames.IDataCloudflareCustomHostnamesHostname
    {
        /// <summary>Filters hostnames by a substring match on the hostname value. This parameter cannot be used with the 'id' parameter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostnames#contain DataCloudflareCustomHostnames#contain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Contain
        {
            get;
            set;
        }
    }
}
