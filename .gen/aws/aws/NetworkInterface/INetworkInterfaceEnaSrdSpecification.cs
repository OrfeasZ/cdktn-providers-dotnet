using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkInterface
{
    [JsiiInterface(nativeType: typeof(INetworkInterfaceEnaSrdSpecification), fullyQualifiedName: "aws.networkInterface.NetworkInterfaceEnaSrdSpecification")]
    public interface INetworkInterfaceEnaSrdSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/network_interface#ena_srd_enabled NetworkInterface#ena_srd_enabled}.</summary>
        [JsiiProperty(name: "enaSrdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnaSrdEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>ena_srd_udp_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/network_interface#ena_srd_udp_specification NetworkInterface#ena_srd_udp_specification}
        /// </remarks>
        [JsiiProperty(name: "enaSrdUdpSpecification", typeJson: "{\"fqn\":\"aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkInterfaceEnaSrdSpecification), fullyQualifiedName: "aws.networkInterface.NetworkInterfaceEnaSrdSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkInterface.INetworkInterfaceEnaSrdSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/network_interface#ena_srd_enabled NetworkInterface#ena_srd_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enaSrdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnaSrdEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ena_srd_udp_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/network_interface#ena_srd_udp_specification NetworkInterface#ena_srd_udp_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enaSrdUdpSpecification", typeJson: "{\"fqn\":\"aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification\"}", isOptional: true)]
            public aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecification
            {
                get => GetInstanceProperty<aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification?>();
            }
        }
    }
}
