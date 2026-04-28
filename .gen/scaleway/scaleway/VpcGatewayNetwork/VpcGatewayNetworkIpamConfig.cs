using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcGatewayNetwork
{
    [JsiiByValue(fqn: "scaleway.vpcGatewayNetwork.VpcGatewayNetworkIpamConfig")]
    public class VpcGatewayNetworkIpamConfig : scaleway.VpcGatewayNetwork.IVpcGatewayNetworkIpamConfig
    {
        /// <summary>Use this IPAM-booked IP ID as the Gateway's IP in this Private Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_gateway_network#ipam_ip_id VpcGatewayNetwork#ipam_ip_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipamIpId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpamIpId
        {
            get;
            set;
        }

        private object? _pushDefaultRoute;

        /// <summary>Defines whether the default route is enabled on that Gateway Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_gateway_network#push_default_route VpcGatewayNetwork#push_default_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pushDefaultRoute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PushDefaultRoute
        {
            get => _pushDefaultRoute;
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
                _pushDefaultRoute = value;
            }
        }
    }
}
