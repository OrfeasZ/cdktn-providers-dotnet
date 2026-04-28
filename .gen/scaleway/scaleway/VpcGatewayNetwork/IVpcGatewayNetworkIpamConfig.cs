using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcGatewayNetwork
{
    [JsiiInterface(nativeType: typeof(IVpcGatewayNetworkIpamConfig), fullyQualifiedName: "scaleway.vpcGatewayNetwork.VpcGatewayNetworkIpamConfig")]
    public interface IVpcGatewayNetworkIpamConfig
    {
        /// <summary>Use this IPAM-booked IP ID as the Gateway's IP in this Private Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_gateway_network#ipam_ip_id VpcGatewayNetwork#ipam_ip_id}
        /// </remarks>
        [JsiiProperty(name: "ipamIpId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpamIpId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines whether the default route is enabled on that Gateway Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_gateway_network#push_default_route VpcGatewayNetwork#push_default_route}
        /// </remarks>
        [JsiiProperty(name: "pushDefaultRoute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PushDefaultRoute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcGatewayNetworkIpamConfig), fullyQualifiedName: "scaleway.vpcGatewayNetwork.VpcGatewayNetworkIpamConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.VpcGatewayNetwork.IVpcGatewayNetworkIpamConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Use this IPAM-booked IP ID as the Gateway's IP in this Private Network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_gateway_network#ipam_ip_id VpcGatewayNetwork#ipam_ip_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipamIpId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpamIpId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines whether the default route is enabled on that Gateway Network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_gateway_network#push_default_route VpcGatewayNetwork#push_default_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pushDefaultRoute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PushDefaultRoute
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
