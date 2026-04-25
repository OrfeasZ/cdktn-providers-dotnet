using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDeviceIpProfile
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustDeviceIpProfile.DataCloudflareZeroTrustDeviceIpProfileFilter")]
    public class DataCloudflareZeroTrustDeviceIpProfileFilter : cloudflare.DataCloudflareZeroTrustDeviceIpProfile.IDataCloudflareZeroTrustDeviceIpProfileFilter
    {
        /// <summary>The number of IP profiles to return per page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_device_ip_profile#per_page DataCloudflareZeroTrustDeviceIpProfile#per_page}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PerPage
        {
            get;
            set;
        }
    }
}
