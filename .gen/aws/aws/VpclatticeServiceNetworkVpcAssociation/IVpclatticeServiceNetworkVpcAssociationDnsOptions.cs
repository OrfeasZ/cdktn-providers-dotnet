using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeServiceNetworkVpcAssociation
{
    [JsiiInterface(nativeType: typeof(IVpclatticeServiceNetworkVpcAssociationDnsOptions), fullyQualifiedName: "aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationDnsOptions")]
    public interface IVpclatticeServiceNetworkVpcAssociationDnsOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/vpclattice_service_network_vpc_association#private_dns_preference VpclatticeServiceNetworkVpcAssociation#private_dns_preference}.</summary>
        [JsiiProperty(name: "privateDnsPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateDnsPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/vpclattice_service_network_vpc_association#private_dns_specified_domains VpclatticeServiceNetworkVpcAssociation#private_dns_specified_domains}.</summary>
        [JsiiProperty(name: "privateDnsSpecifiedDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PrivateDnsSpecifiedDomains
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeServiceNetworkVpcAssociationDnsOptions), fullyQualifiedName: "aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationDnsOptions")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationDnsOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/vpclattice_service_network_vpc_association#private_dns_preference VpclatticeServiceNetworkVpcAssociation#private_dns_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateDnsPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateDnsPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/vpclattice_service_network_vpc_association#private_dns_specified_domains VpclatticeServiceNetworkVpcAssociation#private_dns_specified_domains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateDnsSpecifiedDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PrivateDnsSpecifiedDomains
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
