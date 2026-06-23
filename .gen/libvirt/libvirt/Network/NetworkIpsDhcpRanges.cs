using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkIpsDhcpRanges")]
    public class NetworkIpsDhcpRanges : libvirt.Network.INetworkIpsDhcpRanges
    {
        /// <summary>Sets the end address (inclusive) of a DHCP range;</summary>
        /// <remarks>
        /// must be an IP in the same subnet as the parent <c>ip</c>.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#end Network#end}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? End
        {
            get;
            set;
        }

        /// <summary>Configures the lease parameters for this static DHCP host entry, such as expiry; the structure and values are user-provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#lease Network#lease}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lease", typeJson: "{\"fqn\":\"libvirt.network.NetworkIpsDhcpRangesLease\"}", isOptional: true)]
        public libvirt.Network.INetworkIpsDhcpRangesLease? Lease
        {
            get;
            set;
        }

        /// <summary>Sets the starting address of a DHCP range;</summary>
        /// <remarks>
        /// must be an IP in the same subnet as the parent <c>ip</c>.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#start Network#start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Start
        {
            get;
            set;
        }
    }
}
