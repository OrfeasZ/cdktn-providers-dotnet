using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpoints")]
    public class ZeroTrustDnsLocationEndpoints : cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#doh ZeroTrustDnsLocation#doh}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "doh", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDoh\"}", isOptional: true)]
        public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDoh? Doh
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#dot ZeroTrustDnsLocation#dot}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dot", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDot\"}", isOptional: true)]
        public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDot? Dot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#ipv4 ZeroTrustDnsLocation#ipv4}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv4\"}", isOptional: true)]
        public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv4? Ipv4
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#ipv6 ZeroTrustDnsLocation#ipv6}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6\"}", isOptional: true)]
        public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv6? Ipv6
        {
            get;
            set;
        }
    }
}
