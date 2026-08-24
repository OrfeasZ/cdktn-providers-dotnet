using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationMaxTtl")]
    public class ZeroTrustDnsLocationMaxTtl : cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationMaxTtl
    {
        /// <summary>`inherit` uses the account `max_ttl_secs`. `override` uses this location's `ttl_secs`. `disabled` leaves returned TTLs unchanged. Available values: "inherit", "override", "disabled".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/zero_trust_dns_location#mode ZeroTrustDnsLocation#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Location-specific cap on DNS response TTLs, in seconds.</summary>
        /// <remarks>
        /// Required when <c>mode</c> is <c>override</c>. Must be omitted when <c>mode</c> is <c>inherit</c> or <c>disabled</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/zero_trust_dns_location#ttl_secs ZeroTrustDnsLocation#ttl_secs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ttlSecs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TtlSecs
        {
            get;
            set;
        }
    }
}
