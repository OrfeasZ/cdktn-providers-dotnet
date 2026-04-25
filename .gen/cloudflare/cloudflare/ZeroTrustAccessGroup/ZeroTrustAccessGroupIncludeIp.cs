using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIp")]
    public class ZeroTrustAccessGroupIncludeIp : cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIp
    {
        /// <summary>An IPv4 or IPv6 CIDR block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#ip ZeroTrustAccessGroup#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public string Ip
        {
            get;
            set;
        }
    }
}
