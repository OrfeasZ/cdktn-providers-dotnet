using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallVpcEndpointAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallVpcEndpointAssociation.NetworkfirewallVpcEndpointAssociationSubnetMapping")]
    public class NetworkfirewallVpcEndpointAssociationSubnetMapping : aws.NetworkfirewallVpcEndpointAssociation.INetworkfirewallVpcEndpointAssociationSubnetMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkfirewall_vpc_endpoint_association#subnet_id NetworkfirewallVpcEndpointAssociation#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkfirewall_vpc_endpoint_association#ip_address_type NetworkfirewallVpcEndpointAssociation#ip_address_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddressType
        {
            get;
            set;
        }
    }
}
