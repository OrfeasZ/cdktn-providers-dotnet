using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkInterface
{
    [JsiiInterface(nativeType: typeof(INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification), fullyQualifiedName: "aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification")]
    public interface INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/network_interface#ena_srd_udp_enabled NetworkInterface#ena_srd_udp_enabled}.</summary>
        [JsiiProperty(name: "enaSrdUdpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnaSrdUdpEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification), fullyQualifiedName: "aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/network_interface#ena_srd_udp_enabled NetworkInterface#ena_srd_udp_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enaSrdUdpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnaSrdUdpEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
