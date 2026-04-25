using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomOriginTrustStore
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareCustomOriginTrustStore.DataCloudflareCustomOriginTrustStoreFilter")]
    public class DataCloudflareCustomOriginTrustStoreFilter : cloudflare.DataCloudflareCustomOriginTrustStore.IDataCloudflareCustomOriginTrustStoreFilter
    {
        /// <summary>Limit to the number of records returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_origin_trust_store#limit DataCloudflareCustomOriginTrustStore#limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Limit
        {
            get;
            set;
        }

        /// <summary>Offset the results.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_origin_trust_store#offset DataCloudflareCustomOriginTrustStore#offset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Offset
        {
            get;
            set;
        }
    }
}
