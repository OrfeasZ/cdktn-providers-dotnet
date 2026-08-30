using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkIps")]
    public class NetworkIps : libvirt.Network.INetworkIps
    {
        /// <summary>Sets the IP address assigned to the network bridge for this family;</summary>
        /// <remarks>
        /// must be a valid IPv4 or IPv6 address (e.g. "192.168.122.1").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#address Network#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Enables and configures DHCP service for this IP configuration, including BOOTP and static host entries.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#dhcp Network#dhcp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dhcp", typeJson: "{\"fqn\":\"libvirt.network.NetworkIpsDhcp\"}", isOptional: true)]
        public libvirt.Network.INetworkIpsDhcp? Dhcp
        {
            get;
            set;
        }

        /// <summary>Selects the IP address family for this address, typically `ipv4` or `ipv6`;</summary>
        /// <remarks>
        /// if omitted, libvirt infers it from the address format.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#family Network#family}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Family
        {
            get;
            set;
        }

        /// <summary>Controls whether DNS PTR records for addresses in this subnet are generated only for this network (`yes`) or can be forwarded (`no`);</summary>
        /// <remarks>
        /// value is <c>yes</c> or <c>no</c>.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#local_ptr Network#local_ptr}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localPtr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalPtr
        {
            get;
            set;
        }

        /// <summary>Sets the IPv4 netmask for this subnet;</summary>
        /// <remarks>
        /// must be a dotted-quad such as <c>255.255.255.0</c> and is mutually exclusive with <c>prefix</c>.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#netmask Network#netmask}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Netmask
        {
            get;
            set;
        }

        /// <summary>Sets the CIDR prefix length for this subnet (commonly used for IPv6, e.g. `64`, but also valid for IPv4); mutually exclusive with `netmask`.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#prefix Network#prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Prefix
        {
            get;
            set;
        }

        /// <summary>Enables optional TFTP service for this network IP and configures its parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#tftp Network#tftp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tftp", typeJson: "{\"fqn\":\"libvirt.network.NetworkIpsTftp\"}", isOptional: true)]
        public libvirt.Network.INetworkIpsTftp? Tftp
        {
            get;
            set;
        }
    }
}
