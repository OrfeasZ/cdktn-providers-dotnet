using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkIpsDhcpHosts")]
    public class NetworkIpsDhcpHosts : libvirt.Network.INetworkIpsDhcpHosts
    {
        /// <summary>Represents the client identifier or DUID for a static DHCP host entry;</summary>
        /// <remarks>
        /// when omitted it is computed from other host attributes.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#id Network#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Sets the fixed IP address that the DHCP server always assigns to this host;</summary>
        /// <remarks>
        /// must be within the network’s address range.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#ip Network#ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }

        /// <summary>Configures the lease parameters for this static DHCP host entry, such as expiry; the structure and values are user-provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#lease Network#lease}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lease", typeJson: "{\"fqn\":\"libvirt.network.NetworkIpsDhcpHostsLease\"}", isOptional: true)]
        public libvirt.Network.INetworkIpsDhcpHostsLease? Lease
        {
            get;
            set;
        }

        /// <summary>Sets the MAC address for a static DHCP host entry; must be a valid MAC such as `52:54:00:12:34:56`.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#mac Network#mac}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mac", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mac
        {
            get;
            set;
        }

        /// <summary>Sets the hostname to be handed out via DHCP for this static host entry; the value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#name Network#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
