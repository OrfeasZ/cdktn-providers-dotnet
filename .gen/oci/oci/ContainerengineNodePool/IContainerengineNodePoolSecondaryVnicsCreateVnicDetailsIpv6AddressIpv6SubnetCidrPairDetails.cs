using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiInterface(nativeType: typeof(IContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails")]
    public interface IContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/containerengine_node_pool#ipv6address ContainerengineNodePool#ipv6address}.</summary>
        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/containerengine_node_pool#ipv6subnet_cidr ContainerengineNodePool#ipv6subnet_cidr}.</summary>
        [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6SubnetCidr
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineNodePool.IContainerengineNodePoolSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/containerengine_node_pool#ipv6address ContainerengineNodePool#ipv6address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/containerengine_node_pool#ipv6subnet_cidr ContainerengineNodePool#ipv6subnet_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6SubnetCidr
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
