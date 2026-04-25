using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessInfrastructureTarget
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessInfrastructureTarget.ZeroTrustAccessInfrastructureTargetIp")]
    public class ZeroTrustAccessInfrastructureTargetIp : cloudflare.ZeroTrustAccessInfrastructureTarget.IZeroTrustAccessInfrastructureTargetIp
    {
        /// <summary>The target's IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_infrastructure_target#ipv4 ZeroTrustAccessInfrastructureTarget#ipv4}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessInfrastructureTarget.ZeroTrustAccessInfrastructureTargetIpIpv4\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessInfrastructureTarget.IZeroTrustAccessInfrastructureTargetIpIpv4? Ipv4
        {
            get;
            set;
        }

        /// <summary>The target's IPv6 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_infrastructure_target#ipv6 ZeroTrustAccessInfrastructureTarget#ipv6}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessInfrastructureTarget.ZeroTrustAccessInfrastructureTargetIpIpv6\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessInfrastructureTarget.IZeroTrustAccessInfrastructureTargetIpIpv6? Ipv6
        {
            get;
            set;
        }
    }
}
