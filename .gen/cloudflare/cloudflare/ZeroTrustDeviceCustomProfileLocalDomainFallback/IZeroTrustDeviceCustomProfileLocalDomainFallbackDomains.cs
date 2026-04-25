using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceCustomProfileLocalDomainFallback
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDeviceCustomProfileLocalDomainFallbackDomains), fullyQualifiedName: "cloudflare.zeroTrustDeviceCustomProfileLocalDomainFallback.ZeroTrustDeviceCustomProfileLocalDomainFallbackDomains")]
    public interface IZeroTrustDeviceCustomProfileLocalDomainFallbackDomains
    {
        /// <summary>The domain suffix to match when resolving locally.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_custom_profile_local_domain_fallback#suffix ZeroTrustDeviceCustomProfileLocalDomainFallback#suffix}
        /// </remarks>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        string Suffix
        {
            get;
        }

        /// <summary>A description of the fallback domain, displayed in the client UI.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_custom_profile_local_domain_fallback#description ZeroTrustDeviceCustomProfileLocalDomainFallback#description}
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

        /// <summary>A list of IP addresses to handle domain resolution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_custom_profile_local_domain_fallback#dns_server ZeroTrustDeviceCustomProfileLocalDomainFallback#dns_server}
        /// </remarks>
        [JsiiProperty(name: "dnsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DnsServer
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDeviceCustomProfileLocalDomainFallbackDomains), fullyQualifiedName: "cloudflare.zeroTrustDeviceCustomProfileLocalDomainFallback.ZeroTrustDeviceCustomProfileLocalDomainFallbackDomains")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDeviceCustomProfileLocalDomainFallback.IZeroTrustDeviceCustomProfileLocalDomainFallbackDomains
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The domain suffix to match when resolving locally.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_custom_profile_local_domain_fallback#suffix ZeroTrustDeviceCustomProfileLocalDomainFallback#suffix}
            /// </remarks>
            [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
            public string Suffix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A description of the fallback domain, displayed in the client UI.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_custom_profile_local_domain_fallback#description ZeroTrustDeviceCustomProfileLocalDomainFallback#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of IP addresses to handle domain resolution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_custom_profile_local_domain_fallback#dns_server ZeroTrustDeviceCustomProfileLocalDomainFallback#dns_server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DnsServer
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
