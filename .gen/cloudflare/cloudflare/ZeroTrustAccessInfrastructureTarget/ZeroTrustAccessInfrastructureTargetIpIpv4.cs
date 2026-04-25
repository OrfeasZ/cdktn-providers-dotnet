using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessInfrastructureTarget
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessInfrastructureTarget.ZeroTrustAccessInfrastructureTargetIpIpv4")]
    public class ZeroTrustAccessInfrastructureTargetIpIpv4 : cloudflare.ZeroTrustAccessInfrastructureTarget.IZeroTrustAccessInfrastructureTargetIpIpv4
    {
        /// <summary>IP address of the target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_infrastructure_target#ip_addr ZeroTrustAccessInfrastructureTarget#ip_addr}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddr
        {
            get;
            set;
        }

        /// <summary>(optional) Private virtual network identifier for the target. If omitted, the default virtual network ID will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_infrastructure_target#virtual_network_id ZeroTrustAccessInfrastructureTarget#virtual_network_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualNetworkId
        {
            get;
            set;
        }
    }
}
