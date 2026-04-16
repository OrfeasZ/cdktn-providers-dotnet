using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcPrivateNetwork
{
    [JsiiByValue(fqn: "scaleway.vpcPrivateNetwork.VpcPrivateNetworkIpv6Subnets")]
    public class VpcPrivateNetworkIpv6Subnets : scaleway.VpcPrivateNetwork.IVpcPrivateNetworkIpv6Subnets
    {
        /// <summary>The subnet CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_private_network#subnet VpcPrivateNetwork#subnet}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Subnet
        {
            get;
            set;
        }
    }
}
