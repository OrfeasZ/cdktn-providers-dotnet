using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceCustomProfile
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDeviceCustomProfileBrowserExtensionConfig), fullyQualifiedName: "cloudflare.zeroTrustDeviceCustomProfile.ZeroTrustDeviceCustomProfileBrowserExtensionConfig")]
    public interface IZeroTrustDeviceCustomProfileBrowserExtensionConfig
    {
        /// <summary>Whether the user may disable the browser extension proxy. Available values: "unlocked", "locked".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_device_custom_profile#proxy_control ZeroTrustDeviceCustomProfile#proxy_control}
        /// </remarks>
        [JsiiProperty(name: "proxyControl", typeJson: "{\"primitive\":\"string\"}")]
        string ProxyControl
        {
            get;
        }

        /// <summary>Whether the browser extension proxy is active.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_device_custom_profile#proxy_enabled ZeroTrustDeviceCustomProfile#proxy_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "proxyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ProxyEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDeviceCustomProfileBrowserExtensionConfig), fullyQualifiedName: "cloudflare.zeroTrustDeviceCustomProfile.ZeroTrustDeviceCustomProfileBrowserExtensionConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDeviceCustomProfile.IZeroTrustDeviceCustomProfileBrowserExtensionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether the user may disable the browser extension proxy. Available values: "unlocked", "locked".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_device_custom_profile#proxy_control ZeroTrustDeviceCustomProfile#proxy_control}
            /// </remarks>
            [JsiiProperty(name: "proxyControl", typeJson: "{\"primitive\":\"string\"}")]
            public string ProxyControl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether the browser extension proxy is active.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_device_custom_profile#proxy_enabled ZeroTrustDeviceCustomProfile#proxy_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "proxyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ProxyEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
