using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceCustomProfile
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustDeviceCustomProfile.ZeroTrustDeviceCustomProfileInclude")]
    public class ZeroTrustDeviceCustomProfileInclude : cloudflare.ZeroTrustDeviceCustomProfile.IZeroTrustDeviceCustomProfileInclude
    {
        /// <summary>The address in CIDR format to include in the tunnel. If `address` is present, `host` must not be present.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_custom_profile#address ZeroTrustDeviceCustomProfile#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>A description of the Split Tunnel item, displayed in the client UI.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_custom_profile#description ZeroTrustDeviceCustomProfile#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>The domain name to include in the tunnel. If `host` is present, `address` must not be present.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_custom_profile#host ZeroTrustDeviceCustomProfile#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Host
        {
            get;
            set;
        }
    }
}
