using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VpcNatGateway
{
    [JsiiByValue(fqn: "digitalocean.vpcNatGateway.VpcNatGatewayEgresses")]
    public class VpcNatGatewayEgresses : digitalocean.VpcNatGateway.IVpcNatGatewayEgresses
    {
        private object? _publicGateways;

        /// <summary>public_gateways block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vpc_nat_gateway#public_gateways VpcNatGateway#public_gateways}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicGateways", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.vpcNatGateway.VpcNatGatewayEgressesPublicGateways\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PublicGateways
        {
            get => _publicGateways;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _publicGateways = value;
            }
        }
    }
}
