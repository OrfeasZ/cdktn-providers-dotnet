using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDeviceCustomProfile
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustDeviceCustomProfile.DataCloudflareZeroTrustDeviceCustomProfileFilter")]
    public class DataCloudflareZeroTrustDeviceCustomProfileFilter : cloudflare.DataCloudflareZeroTrustDeviceCustomProfile.IDataCloudflareZeroTrustDeviceCustomProfileFilter
    {
        /// <summary>Filter profiles by client type. When omitted, only WARP profiles are returned. Available values: "warp", "browser_extension".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_device_custom_profile#profile_type DataCloudflareZeroTrustDeviceCustomProfile#profile_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "profileType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProfileType
        {
            get;
            set;
        }
    }
}
