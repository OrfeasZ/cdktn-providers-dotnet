using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VpcNatGateway
{
    [JsiiByValue(fqn: "digitalocean.vpcNatGateway.VpcNatGatewayEgressesPublicGateways")]
    public class VpcNatGatewayEgressesPublicGateways : digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways
    {
        /// <summary>IPv4 address.</summary>
        /// <remarks>
        /// On create, set this to an unassigned BYOIP on the account in the same region. When omitted, a system-allocated reserved IP is provisioned.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vpc_nat_gateway#ipv4 VpcNatGateway#ipv4}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv4
        {
            get;
            set;
        }
    }
}
