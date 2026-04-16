using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VpcNatGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.vpcNatGateway.VpcNatGatewayVpcs")]
    public class VpcNatGatewayVpcs : digitalocean.VpcNatGateway.IVpcNatGatewayVpcs
    {
        /// <summary>ID of the ingress VPC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/vpc_nat_gateway#vpc_uuid VpcNatGateway#vpc_uuid}
        /// </remarks>
        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcUuid
        {
            get;
            set;
        }

        private object? _defaultGateway;

        /// <summary>Indicates if this is the default VPC NAT Gateway in the VPC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/vpc_nat_gateway#default_gateway VpcNatGateway#default_gateway}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultGateway", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DefaultGateway
        {
            get => _defaultGateway;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _defaultGateway = value;
            }
        }
    }
}
