using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreClusterNetwork
{
    [JsiiInterface(nativeType: typeof(ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails), fullyQualifiedName: "oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails")]
    public interface ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#ipv6subnet_cidr CoreClusterNetwork#ipv6subnet_cidr}.</summary>
        [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6SubnetCidr
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails), fullyQualifiedName: "oci.coreClusterNetwork.CoreClusterNetworkPlacementConfigurationPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreClusterNetwork.ICoreClusterNetworkPlacementConfigurationPrimaryVnicSubnetsIpv6AddressIpv6SubnetCidrPairDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cluster_network#ipv6subnet_cidr CoreClusterNetwork#ipv6subnet_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6SubnetCidr
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
