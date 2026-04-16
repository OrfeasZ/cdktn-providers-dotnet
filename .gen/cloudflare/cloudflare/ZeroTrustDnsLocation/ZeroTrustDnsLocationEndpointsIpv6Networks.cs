using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6Networks")]
    public class ZeroTrustDnsLocationEndpointsIpv6Networks : cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv6Networks
    {
        /// <summary>Specify the IPv6 address or IPv6 CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dns_location#network ZeroTrustDnsLocation#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
        public string Network
        {
            get;
            set;
        }
    }
}
