using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceDefaultProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDeviceDefaultProfile.ZeroTrustDeviceDefaultProfileVirtualNetworks")]
    public class ZeroTrustDeviceDefaultProfileVirtualNetworks : cloudflare.ZeroTrustDeviceDefaultProfile.IZeroTrustDeviceDefaultProfileVirtualNetworks
    {
        /// <summary>List of virtual network IDs the device is allowed to access.</summary>
        /// <remarks>
        /// When virtual_networks is set, at least one entry is required.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/zero_trust_device_default_profile#allowed ZeroTrustDeviceDefaultProfile#allowed}
        /// </remarks>
        [JsiiProperty(name: "allowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Allowed
        {
            get;
            set;
        }

        /// <summary>The default virtual network ID. Must be included in the `allowed` list.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/zero_trust_device_default_profile#default ZeroTrustDeviceDefaultProfile#default}
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}")]
        public string Default
        {
            get;
            set;
        }
    }
}
