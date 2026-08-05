using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceCustomProfile
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDeviceCustomProfileGlobalAcceleration), fullyQualifiedName: "cloudflare.zeroTrustDeviceCustomProfile.ZeroTrustDeviceCustomProfileGlobalAcceleration")]
    public interface IZeroTrustDeviceCustomProfileGlobalAcceleration
    {
        /// <summary>IP:port entries for the API endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_custom_profile#api_endpoints ZeroTrustDeviceCustomProfile#api_endpoints}
        /// </remarks>
        [JsiiProperty(name: "apiEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ApiEndpoints
        {
            get;
        }

        /// <summary>Global acceleration settings are used only when "enabled".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_custom_profile#enabled ZeroTrustDeviceCustomProfile#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>IP:port entries for the MASQUE tunnel endpoints. Either wireguard_endpoints or masque_endpoints must be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_custom_profile#masque_endpoints ZeroTrustDeviceCustomProfile#masque_endpoints}
        /// </remarks>
        [JsiiProperty(name: "masqueEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] MasqueEndpoints
        {
            get;
        }

        /// <summary>IP:port entries for the WireGuard tunnel endpoints. Either wireguard_endpoints or masque_endpoints must be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_custom_profile#wireguard_endpoints ZeroTrustDeviceCustomProfile#wireguard_endpoints}
        /// </remarks>
        [JsiiProperty(name: "wireguardEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] WireguardEndpoints
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDeviceCustomProfileGlobalAcceleration), fullyQualifiedName: "cloudflare.zeroTrustDeviceCustomProfile.ZeroTrustDeviceCustomProfileGlobalAcceleration")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDeviceCustomProfile.IZeroTrustDeviceCustomProfileGlobalAcceleration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>IP:port entries for the API endpoints.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_custom_profile#api_endpoints ZeroTrustDeviceCustomProfile#api_endpoints}
            /// </remarks>
            [JsiiProperty(name: "apiEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ApiEndpoints
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Global acceleration settings are used only when "enabled".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_custom_profile#enabled ZeroTrustDeviceCustomProfile#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>IP:port entries for the MASQUE tunnel endpoints. Either wireguard_endpoints or masque_endpoints must be provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_custom_profile#masque_endpoints ZeroTrustDeviceCustomProfile#masque_endpoints}
            /// </remarks>
            [JsiiProperty(name: "masqueEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] MasqueEndpoints
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>IP:port entries for the WireGuard tunnel endpoints. Either wireguard_endpoints or masque_endpoints must be provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_custom_profile#wireguard_endpoints ZeroTrustDeviceCustomProfile#wireguard_endpoints}
            /// </remarks>
            [JsiiProperty(name: "wireguardEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] WireguardEndpoints
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
