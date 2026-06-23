using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.network.NetworkForwardNatPorts")]
    public class NetworkForwardNatPorts : libvirt.Network.INetworkForwardNatPorts
    {
        /// <summary>Sets the last port number in the NAT port range;</summary>
        /// <remarks>
        /// must be an integer between 1 and 65535 and &gt;= the start port.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#end Network#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
        public double End
        {
            get;
            set;
        }

        /// <summary>Sets the first port number in the NAT port range;</summary>
        /// <remarks>
        /// must be an integer between 1 and 65535 (e.g. 1024).
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#start Network#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        public double Start
        {
            get;
            set;
        }
    }
}
