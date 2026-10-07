using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkInterface
{
    [JsiiByValue(fqn: "aws.networkInterface.NetworkInterfaceConnectionTrackingSpecification")]
    public class NetworkInterfaceConnectionTrackingSpecification : aws.NetworkInterface.INetworkInterfaceConnectionTrackingSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/network_interface#tcp_established_timeout NetworkInterface#tcp_established_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tcpEstablishedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TcpEstablishedTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/network_interface#udp_stream_timeout NetworkInterface#udp_stream_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "udpStreamTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UdpStreamTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/network_interface#udp_timeout NetworkInterface#udp_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "udpTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UdpTimeout
        {
            get;
            set;
        }
    }
}
