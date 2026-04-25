using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpoints")]
    public class ZeroTrustDnsLocationEndpoints : cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#doh ZeroTrustDnsLocation#doh}.</summary>
        [JsiiProperty(name: "doh", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDoh\"}")]
        public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDoh Doh
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#dot ZeroTrustDnsLocation#dot}.</summary>
        [JsiiProperty(name: "dot", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDot\"}")]
        public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDot Dot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#ipv4 ZeroTrustDnsLocation#ipv4}.</summary>
        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv4\"}")]
        public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv4 Ipv4
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#ipv6 ZeroTrustDnsLocation#ipv6}.</summary>
        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6\"}")]
        public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv6 Ipv6
        {
            get;
            set;
        }
    }
}
