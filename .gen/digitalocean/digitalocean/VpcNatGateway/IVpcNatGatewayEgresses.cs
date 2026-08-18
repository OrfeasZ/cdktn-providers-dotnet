using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VpcNatGateway
{
    [JsiiInterface(nativeType: typeof(IVpcNatGatewayEgresses), fullyQualifiedName: "digitalocean.vpcNatGateway.VpcNatGatewayEgresses")]
    public interface IVpcNatGatewayEgresses
    {
        /// <summary>public_gateways block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vpc_nat_gateway#public_gateways VpcNatGateway#public_gateways}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "publicGateways", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.vpcNatGateway.VpcNatGatewayEgressesPublicGateways\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicGateways
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcNatGatewayEgresses), fullyQualifiedName: "digitalocean.vpcNatGateway.VpcNatGatewayEgresses")]
        internal sealed class _Proxy : DeputyBase, digitalocean.VpcNatGateway.IVpcNatGatewayEgresses
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>public_gateways block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vpc_nat_gateway#public_gateways VpcNatGateway#public_gateways}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicGateways", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.vpcNatGateway.VpcNatGatewayEgressesPublicGateways\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PublicGateways
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
