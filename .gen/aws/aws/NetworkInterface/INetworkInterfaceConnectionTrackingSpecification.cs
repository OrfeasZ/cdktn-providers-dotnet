using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkInterface
{
    [JsiiInterface(nativeType: typeof(INetworkInterfaceConnectionTrackingSpecification), fullyQualifiedName: "aws.networkInterface.NetworkInterfaceConnectionTrackingSpecification")]
    public interface INetworkInterfaceConnectionTrackingSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/network_interface#tcp_established_timeout NetworkInterface#tcp_established_timeout}.</summary>
        [JsiiProperty(name: "tcpEstablishedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TcpEstablishedTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/network_interface#udp_stream_timeout NetworkInterface#udp_stream_timeout}.</summary>
        [JsiiProperty(name: "udpStreamTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UdpStreamTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/network_interface#udp_timeout NetworkInterface#udp_timeout}.</summary>
        [JsiiProperty(name: "udpTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UdpTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkInterfaceConnectionTrackingSpecification), fullyQualifiedName: "aws.networkInterface.NetworkInterfaceConnectionTrackingSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkInterface.INetworkInterfaceConnectionTrackingSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/network_interface#tcp_established_timeout NetworkInterface#tcp_established_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tcpEstablishedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TcpEstablishedTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/network_interface#udp_stream_timeout NetworkInterface#udp_stream_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "udpStreamTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UdpStreamTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/network_interface#udp_timeout NetworkInterface#udp_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "udpTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UdpTimeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
