using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceCustomProfile
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDeviceCustomProfileVirtualNetworks), fullyQualifiedName: "cloudflare.zeroTrustDeviceCustomProfile.ZeroTrustDeviceCustomProfileVirtualNetworks")]
    public interface IZeroTrustDeviceCustomProfileVirtualNetworks
    {
        /// <summary>List of virtual network IDs the device is allowed to access.</summary>
        /// <remarks>
        /// When virtual_networks is set, at least one entry is required.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_device_custom_profile#allowed ZeroTrustDeviceCustomProfile#allowed}
        /// </remarks>
        [JsiiProperty(name: "allowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Allowed
        {
            get;
        }

        /// <summary>The default virtual network ID. Must be included in the `allowed` list.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_device_custom_profile#default ZeroTrustDeviceCustomProfile#default}
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}")]
        string Default
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDeviceCustomProfileVirtualNetworks), fullyQualifiedName: "cloudflare.zeroTrustDeviceCustomProfile.ZeroTrustDeviceCustomProfileVirtualNetworks")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDeviceCustomProfile.IZeroTrustDeviceCustomProfileVirtualNetworks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of virtual network IDs the device is allowed to access.</summary>
            /// <remarks>
            /// When virtual_networks is set, at least one entry is required.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_device_custom_profile#allowed ZeroTrustDeviceCustomProfile#allowed}
            /// </remarks>
            [JsiiProperty(name: "allowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Allowed
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The default virtual network ID. Must be included in the `allowed` list.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_device_custom_profile#default ZeroTrustDeviceCustomProfile#default}
            /// </remarks>
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}")]
            public string Default
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
