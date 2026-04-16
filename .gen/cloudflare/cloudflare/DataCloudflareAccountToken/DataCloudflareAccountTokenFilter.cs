using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountToken
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareAccountToken.DataCloudflareAccountTokenFilter")]
    public class DataCloudflareAccountTokenFilter : cloudflare.DataCloudflareAccountToken.IDataCloudflareAccountTokenFilter
    {
        /// <summary>Direction to order results. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_token#direction DataCloudflareAccountToken#direction}
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
