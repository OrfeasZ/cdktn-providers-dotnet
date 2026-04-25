using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustList
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustList.DataCloudflareZeroTrustListFilter")]
    public class DataCloudflareZeroTrustListFilter : cloudflare.DataCloudflareZeroTrustList.IDataCloudflareZeroTrustListFilter
    {
        /// <summary>Specify the list type. Available values: "SERIAL", "URL", "DOMAIN", "EMAIL", "IP", "CATEGORY", "LOCATION", "DEVICE", "AAGUID".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_list#type DataCloudflareZeroTrustList#type}
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
