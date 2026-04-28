using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcPrivateNetwork
{
    [JsiiInterface(nativeType: typeof(IVpcPrivateNetworkIpv6Subnets), fullyQualifiedName: "scaleway.vpcPrivateNetwork.VpcPrivateNetworkIpv6Subnets")]
    public interface IVpcPrivateNetworkIpv6Subnets
    {
        /// <summary>The subnet CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_private_network#subnet VpcPrivateNetwork#subnet}
        /// </remarks>
        [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Subnet
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcPrivateNetworkIpv6Subnets), fullyQualifiedName: "scaleway.vpcPrivateNetwork.VpcPrivateNetworkIpv6Subnets")]
        internal sealed class _Proxy : DeputyBase, scaleway.VpcPrivateNetwork.IVpcPrivateNetworkIpv6Subnets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The subnet CIDR.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_private_network#subnet VpcPrivateNetwork#subnet}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Subnet
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
