using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesIp")]
    public class DomainDevicesInterfacesIp : libvirt.Domain.IDomainDevicesInterfacesIp
    {
        /// <summary>Sets the IP address assigned to the interface in the guest;</summary>
        /// <remarks>
        /// must be a valid IPv4 or IPv6 address string (for example, "192.168.122.10" or "2001:db8::10").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Selects the address family for the interface IP, typically "ipv4" or "ipv6";</summary>
        /// <remarks>
        /// if omitted, libvirt infers it from the address format.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#family Domain#family}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Family
        {
            get;
            set;
        }

        /// <summary>Sets the peer address for point-to-point style links, as a valid IPv4 or IPv6 address string; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#peer Domain#peer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "peer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Peer
        {
            get;
            set;
        }

        /// <summary>Sets the prefix length (CIDR) for the interface IP address as a non-negative integer (for example, 24 for "192.168.122.0/24").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#prefix Domain#prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Prefix
        {
            get;
            set;
        }
    }
}
