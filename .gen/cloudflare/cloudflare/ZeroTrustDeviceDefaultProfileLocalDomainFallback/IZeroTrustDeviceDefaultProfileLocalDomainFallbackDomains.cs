using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceDefaultProfileLocalDomainFallback
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDeviceDefaultProfileLocalDomainFallbackDomains), fullyQualifiedName: "cloudflare.zeroTrustDeviceDefaultProfileLocalDomainFallback.ZeroTrustDeviceDefaultProfileLocalDomainFallbackDomains")]
    public interface IZeroTrustDeviceDefaultProfileLocalDomainFallbackDomains
    {
        /// <summary>The domain suffix to match when resolving locally.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_default_profile_local_domain_fallback#suffix ZeroTrustDeviceDefaultProfileLocalDomainFallback#suffix}
        /// </remarks>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        string Suffix
        {
            get;
        }

        /// <summary>A description of the fallback domain, displayed in the client UI.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_default_profile_local_domain_fallback#description ZeroTrustDeviceDefaultProfileLocalDomainFallback#description}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_default_profile_local_domain_fallback#dns_server ZeroTrustDeviceDefaultProfileLocalDomainFallback#dns_server}
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

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDeviceDefaultProfileLocalDomainFallbackDomains), fullyQualifiedName: "cloudflare.zeroTrustDeviceDefaultProfileLocalDomainFallback.ZeroTrustDeviceDefaultProfileLocalDomainFallbackDomains")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDeviceDefaultProfileLocalDomainFallback.IZeroTrustDeviceDefaultProfileLocalDomainFallbackDomains
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The domain suffix to match when resolving locally.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_default_profile_local_domain_fallback#suffix ZeroTrustDeviceDefaultProfileLocalDomainFallback#suffix}
            /// </remarks>
            [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
            public string Suffix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A description of the fallback domain, displayed in the client UI.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_default_profile_local_domain_fallback#description ZeroTrustDeviceDefaultProfileLocalDomainFallback#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of IP addresses to handle domain resolution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_device_default_profile_local_domain_fallback#dns_server ZeroTrustDeviceDefaultProfileLocalDomainFallback#dns_server}
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
