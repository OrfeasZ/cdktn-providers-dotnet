using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VpcNatGateway
{
    [JsiiInterface(nativeType: typeof(IVpcNatGatewayEgressesPublicGateways), fullyQualifiedName: "digitalocean.vpcNatGateway.VpcNatGatewayEgressesPublicGateways")]
    public interface IVpcNatGatewayEgressesPublicGateways
    {
        /// <summary>IPv4 address.</summary>
        /// <remarks>
        /// On create, set this to an unassigned BYOIP on the account in the same region. When omitted, a system-allocated reserved IP is provisioned.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vpc_nat_gateway#ipv4 VpcNatGateway#ipv4}
        /// </remarks>
        [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv4
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcNatGatewayEgressesPublicGateways), fullyQualifiedName: "digitalocean.vpcNatGateway.VpcNatGatewayEgressesPublicGateways")]
        internal sealed class _Proxy : DeputyBase, digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
