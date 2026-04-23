using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeServiceNetworkVpcAssociation
{
    [JsiiByValue(fqn: "aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationDnsOptions")]
    public class VpclatticeServiceNetworkVpcAssociationDnsOptions : aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationDnsOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#private_dns_preference VpclatticeServiceNetworkVpcAssociation#private_dns_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateDnsPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateDnsPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#private_dns_specified_domains VpclatticeServiceNetworkVpcAssociation#private_dns_specified_domains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateDnsSpecifiedDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PrivateDnsSpecifiedDomains
        {
            get;
            set;
        }
    }
}
