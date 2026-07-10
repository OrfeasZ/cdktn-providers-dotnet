using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDnsLocationMaxTtl), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationMaxTtl")]
    public interface IZeroTrustDnsLocationMaxTtl
    {
        /// <summary>`inherit` uses the account `max_ttl_secs`. `override` uses this location's `ttl_secs`. `disabled` leaves returned TTLs unchanged. Available values: "inherit", "override", "disabled".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_dns_location#mode ZeroTrustDnsLocation#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Location-specific cap on DNS response TTLs, in seconds.</summary>
        /// <remarks>
        /// Required when <c>mode</c> is <c>override</c>. Must be omitted when <c>mode</c> is <c>inherit</c> or <c>disabled</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_dns_location#ttl_secs ZeroTrustDnsLocation#ttl_secs}
        /// </remarks>
        [JsiiProperty(name: "ttlSecs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TtlSecs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDnsLocationMaxTtl), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationMaxTtl")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationMaxTtl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`inherit` uses the account `max_ttl_secs`. `override` uses this location's `ttl_secs`. `disabled` leaves returned TTLs unchanged. Available values: "inherit", "override", "disabled".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_dns_location#mode ZeroTrustDnsLocation#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Location-specific cap on DNS response TTLs, in seconds.</summary>
            /// <remarks>
            /// Required when <c>mode</c> is <c>override</c>. Must be omitted when <c>mode</c> is <c>inherit</c> or <c>disabled</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_dns_location#ttl_secs ZeroTrustDnsLocation#ttl_secs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ttlSecs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TtlSecs
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
