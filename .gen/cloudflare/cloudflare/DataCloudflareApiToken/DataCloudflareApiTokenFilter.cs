using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiToken
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareApiToken.DataCloudflareApiTokenFilter")]
    public class DataCloudflareApiTokenFilter : cloudflare.DataCloudflareApiToken.IDataCloudflareApiTokenFilter
    {
        /// <summary>Direction to order results. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_token#direction DataCloudflareApiToken#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}
