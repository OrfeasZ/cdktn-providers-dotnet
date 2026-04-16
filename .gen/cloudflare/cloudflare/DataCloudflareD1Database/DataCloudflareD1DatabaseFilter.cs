using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareD1Database
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareD1Database.DataCloudflareD1DatabaseFilter")]
    public class DataCloudflareD1DatabaseFilter : cloudflare.DataCloudflareD1Database.IDataCloudflareD1DatabaseFilter
    {
        /// <summary>a database name to search for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/d1_database#name DataCloudflareD1Database#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
