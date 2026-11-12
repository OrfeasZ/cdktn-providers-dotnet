using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOriginCaCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.dataCloudflareOriginCaCertificate.DataCloudflareOriginCaCertificateFilter")]
    public class DataCloudflareOriginCaCertificateFilter : cloudflare.DataCloudflareOriginCaCertificate.IDataCloudflareOriginCaCertificateFilter
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/origin_ca_certificate#zone_id DataCloudflareOriginCaCertificate#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public string ZoneId
        {
            get;
            set;
        }
    }
}
