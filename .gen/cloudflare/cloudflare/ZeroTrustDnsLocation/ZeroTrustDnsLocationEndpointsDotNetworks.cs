using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDotNetworks")]
    public class ZeroTrustDnsLocationEndpointsDotNetworks : cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDotNetworks
    {
        /// <summary>Specify the IP address or IP CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#network ZeroTrustDnsLocation#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
        public string Network
        {
            get;
            set;
        }
    }
}
