using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VpcNatGateway
{
    [JsiiInterface(nativeType: typeof(IVpcNatGatewayVpcs), fullyQualifiedName: "digitalocean.vpcNatGateway.VpcNatGatewayVpcs")]
    public interface IVpcNatGatewayVpcs
    {
        /// <summary>ID of the ingress VPC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/vpc_nat_gateway#vpc_uuid VpcNatGateway#vpc_uuid}
        /// </remarks>
        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        string VpcUuid
        {
            get;
        }

        /// <summary>Indicates if this is the default VPC NAT Gateway in the VPC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/vpc_nat_gateway#default_gateway VpcNatGateway#default_gateway}
        /// </remarks>
        [JsiiProperty(name: "defaultGateway", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultGateway
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcNatGatewayVpcs), fullyQualifiedName: "digitalocean.vpcNatGateway.VpcNatGatewayVpcs")]
        internal sealed class _Proxy : DeputyBase, digitalocean.VpcNatGateway.IVpcNatGatewayVpcs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the ingress VPC.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/vpc_nat_gateway#vpc_uuid VpcNatGateway#vpc_uuid}
            /// </remarks>
            [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcUuid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Indicates if this is the default VPC NAT Gateway in the VPC.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/vpc_nat_gateway#default_gateway VpcNatGateway#default_gateway}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultGateway", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DefaultGateway
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
