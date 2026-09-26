using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceCustomProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDeviceCustomProfile.ZeroTrustDeviceCustomProfileBrowserExtensionConfig")]
    public class ZeroTrustDeviceCustomProfileBrowserExtensionConfig : cloudflare.ZeroTrustDeviceCustomProfile.IZeroTrustDeviceCustomProfileBrowserExtensionConfig
    {
        /// <summary>Whether the user may disable the browser extension proxy. Available values: "unlocked", "locked".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_device_custom_profile#proxy_control ZeroTrustDeviceCustomProfile#proxy_control}
        /// </remarks>
        [JsiiProperty(name: "proxyControl", typeJson: "{\"primitive\":\"string\"}")]
        public string ProxyControl
        {
            get;
            set;
        }

        private object _proxyEnabled;

        /// <summary>Whether the browser extension proxy is active.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_device_custom_profile#proxy_enabled ZeroTrustDeviceCustomProfile#proxy_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "proxyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object ProxyEnabled
        {
            get => _proxyEnabled;
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
                _proxyEnabled = value;
            }
        }
    }
}
