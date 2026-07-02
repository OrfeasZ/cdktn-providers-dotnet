using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiByValue(fqn: "oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails")]
    public class ContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails : oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/containerengine_node_pool#ipv6address ContainerengineNodePool#ipv6address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/containerengine_node_pool#ipv6subnet_cidr ContainerengineNodePool#ipv6subnet_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6SubnetCidr
        {
            get;
            set;
        }
    }
}
