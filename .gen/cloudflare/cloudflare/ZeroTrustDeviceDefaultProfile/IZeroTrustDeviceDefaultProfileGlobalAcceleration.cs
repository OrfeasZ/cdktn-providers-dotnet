using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceDefaultProfile
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDeviceDefaultProfileGlobalAcceleration), fullyQualifiedName: "cloudflare.zeroTrustDeviceDefaultProfile.ZeroTrustDeviceDefaultProfileGlobalAcceleration")]
    public interface IZeroTrustDeviceDefaultProfileGlobalAcceleration
    {
        /// <summary>IP:port entries for the API endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#api_endpoints ZeroTrustDeviceDefaultProfile#api_endpoints}
        /// </remarks>
        [JsiiProperty(name: "apiEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ApiEndpoints
        {
            get;
        }

        /// <summary>Global acceleration settings are used only when "enabled".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#enabled ZeroTrustDeviceDefaultProfile#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>IP:port entries for the MASQUE tunnel endpoints. Either wireguard_endpoints or masque_endpoints must be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#masque_endpoints ZeroTrustDeviceDefaultProfile#masque_endpoints}
        /// </remarks>
        [JsiiProperty(name: "masqueEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] MasqueEndpoints
        {
            get;
        }

        /// <summary>IP:port entries for the WireGuard tunnel endpoints. Either wireguard_endpoints or masque_endpoints must be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#wireguard_endpoints ZeroTrustDeviceDefaultProfile#wireguard_endpoints}
        /// </remarks>
        [JsiiProperty(name: "wireguardEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] WireguardEndpoints
        {
            get;
        }

        /// <summary>Whether WARP users may manually override the automatic Global Acceleration decision. Defaults to true when not provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#allow_manual_override ZeroTrustDeviceDefaultProfile#allow_manual_override}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "allowManualOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowManualOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Automatically switch Global Acceleration regions based on device location. Defaults to false when not provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#autoswitch ZeroTrustDeviceDefaultProfile#autoswitch}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoswitch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Autoswitch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDeviceDefaultProfileGlobalAcceleration), fullyQualifiedName: "cloudflare.zeroTrustDeviceDefaultProfile.ZeroTrustDeviceDefaultProfileGlobalAcceleration")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDeviceDefaultProfile.IZeroTrustDeviceDefaultProfileGlobalAcceleration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>IP:port entries for the API endpoints.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#api_endpoints ZeroTrustDeviceDefaultProfile#api_endpoints}
            /// </remarks>
            [JsiiProperty(name: "apiEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ApiEndpoints
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Global acceleration settings are used only when "enabled".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#enabled ZeroTrustDeviceDefaultProfile#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>IP:port entries for the MASQUE tunnel endpoints. Either wireguard_endpoints or masque_endpoints must be provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#masque_endpoints ZeroTrustDeviceDefaultProfile#masque_endpoints}
            /// </remarks>
            [JsiiProperty(name: "masqueEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] MasqueEndpoints
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>IP:port entries for the WireGuard tunnel endpoints. Either wireguard_endpoints or masque_endpoints must be provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#wireguard_endpoints ZeroTrustDeviceDefaultProfile#wireguard_endpoints}
            /// </remarks>
            [JsiiProperty(name: "wireguardEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] WireguardEndpoints
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Whether WARP users may manually override the automatic Global Acceleration decision. Defaults to true when not provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#allow_manual_override ZeroTrustDeviceDefaultProfile#allow_manual_override}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowManualOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowManualOverride
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Automatically switch Global Acceleration regions based on device location. Defaults to false when not provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_default_profile#autoswitch ZeroTrustDeviceDefaultProfile#autoswitch}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoswitch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Autoswitch
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
