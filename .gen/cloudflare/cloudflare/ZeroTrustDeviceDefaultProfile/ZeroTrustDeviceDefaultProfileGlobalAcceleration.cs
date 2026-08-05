using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceDefaultProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDeviceDefaultProfile.ZeroTrustDeviceDefaultProfileGlobalAcceleration")]
    public class ZeroTrustDeviceDefaultProfileGlobalAcceleration : cloudflare.ZeroTrustDeviceDefaultProfile.IZeroTrustDeviceDefaultProfileGlobalAcceleration
    {
        /// <summary>IP:port entries for the API endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_default_profile#api_endpoints ZeroTrustDeviceDefaultProfile#api_endpoints}
        /// </remarks>
        [JsiiProperty(name: "apiEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ApiEndpoints
        {
            get;
            set;
        }

        private object _enabled;

        /// <summary>Global acceleration settings are used only when "enabled".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_default_profile#enabled ZeroTrustDeviceDefaultProfile#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>IP:port entries for the MASQUE tunnel endpoints. Either wireguard_endpoints or masque_endpoints must be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_default_profile#masque_endpoints ZeroTrustDeviceDefaultProfile#masque_endpoints}
        /// </remarks>
        [JsiiProperty(name: "masqueEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] MasqueEndpoints
        {
            get;
            set;
        }

        /// <summary>IP:port entries for the WireGuard tunnel endpoints. Either wireguard_endpoints or masque_endpoints must be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_device_default_profile#wireguard_endpoints ZeroTrustDeviceDefaultProfile#wireguard_endpoints}
        /// </remarks>
        [JsiiProperty(name: "wireguardEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] WireguardEndpoints
        {
            get;
            set;
        }
    }
}
