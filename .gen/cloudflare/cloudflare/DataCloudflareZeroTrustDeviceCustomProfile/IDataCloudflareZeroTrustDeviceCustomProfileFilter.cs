using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDeviceCustomProfile
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustDeviceCustomProfileFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDeviceCustomProfile.DataCloudflareZeroTrustDeviceCustomProfileFilter")]
    public interface IDataCloudflareZeroTrustDeviceCustomProfileFilter
    {
        /// <summary>Filter profiles by client type. When omitted, only WARP profiles are returned. Available values: "warp", "browser_extension".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_device_custom_profile#profile_type DataCloudflareZeroTrustDeviceCustomProfile#profile_type}
        /// </remarks>
        [JsiiProperty(name: "profileType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProfileType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustDeviceCustomProfileFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDeviceCustomProfile.DataCloudflareZeroTrustDeviceCustomProfileFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustDeviceCustomProfile.IDataCloudflareZeroTrustDeviceCustomProfileFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter profiles by client type. When omitted, only WARP profiles are returned. Available values: "warp", "browser_extension".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_device_custom_profile#profile_type DataCloudflareZeroTrustDeviceCustomProfile#profile_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profileType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProfileType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
