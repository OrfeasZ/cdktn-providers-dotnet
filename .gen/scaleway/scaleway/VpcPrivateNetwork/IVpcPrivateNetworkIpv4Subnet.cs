using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcPrivateNetwork
{
    [JsiiInterface(nativeType: typeof(IVpcPrivateNetworkIpv4Subnet), fullyQualifiedName: "scaleway.vpcPrivateNetwork.VpcPrivateNetworkIpv4Subnet")]
    public interface IVpcPrivateNetworkIpv4Subnet
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

        [JsiiTypeProxy(nativeType: typeof(IVpcPrivateNetworkIpv4Subnet), fullyQualifiedName: "scaleway.vpcPrivateNetwork.VpcPrivateNetworkIpv4Subnet")]
        internal sealed class _Proxy : DeputyBase, scaleway.VpcPrivateNetwork.IVpcPrivateNetworkIpv4Subnet
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
