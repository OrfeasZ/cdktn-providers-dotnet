using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkIpsTftp")]
    public class NetworkIpsTftp : libvirt.Network.INetworkIpsTftp
    {
        /// <summary>Sets the filesystem directory that TFTP will expose as its root for this network IP;</summary>
        /// <remarks>
        /// value is a host path such as <c>/var/lib/tftpboot</c>.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#root Network#root}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "root", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Root
        {
            get;
            set;
        }
    }
}
