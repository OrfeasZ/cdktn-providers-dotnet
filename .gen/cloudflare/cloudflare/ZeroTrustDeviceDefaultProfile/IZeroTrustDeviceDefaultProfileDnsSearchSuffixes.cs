using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceDefaultProfile
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDeviceDefaultProfileDnsSearchSuffixes), fullyQualifiedName: "cloudflare.zeroTrustDeviceDefaultProfile.ZeroTrustDeviceDefaultProfileDnsSearchSuffixes")]
    public interface IZeroTrustDeviceDefaultProfileDnsSearchSuffixes
    {
        /// <summary>The DNS search suffix to append when resolving short hostnames.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_device_default_profile#suffix ZeroTrustDeviceDefaultProfile#suffix}
        /// </remarks>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        string Suffix
        {
            get;
        }

        /// <summary>A description of the DNS search suffix.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_device_default_profile#description ZeroTrustDeviceDefaultProfile#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDeviceDefaultProfileDnsSearchSuffixes), fullyQualifiedName: "cloudflare.zeroTrustDeviceDefaultProfile.ZeroTrustDeviceDefaultProfileDnsSearchSuffixes")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDeviceDefaultProfile.IZeroTrustDeviceDefaultProfileDnsSearchSuffixes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The DNS search suffix to append when resolving short hostnames.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_device_default_profile#suffix ZeroTrustDeviceDefaultProfile#suffix}
            /// </remarks>
            [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
            public string Suffix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A description of the DNS search suffix.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_device_default_profile#description ZeroTrustDeviceDefaultProfile#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
