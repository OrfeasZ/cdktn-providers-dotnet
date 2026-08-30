using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesRoute")]
    public class DomainDevicesInterfacesRoute : libvirt.Domain.IDomainDevicesInterfacesRoute
    {
        /// <summary>Sets the gateway IP address used for the static route (must be in the same family as the route address, for example "192.168.10.1").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#gateway Domain#gateway}
        /// </remarks>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        public string Gateway
        {
            get;
            set;
        }

        /// <summary>Sets the destination network address for the static route, as an IPv4 or IPv6 address depending on the family (for example, "192.168.10.0" or "2001:db8::").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Specifies the address family for the route, typically "ipv4" or "ipv6";</summary>
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

        /// <summary>Sets an optional numeric route metric (preference) for the static route, as a non-negative integer where lower values are preferred.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#metric Domain#metric}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metric", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Metric
        {
            get;
            set;
        }

        /// <summary>Specifies the netmask for an IPv4 static route as a dotted-quad mask (for example, "255.255.255.0"); use prefix instead for IPv6 or CIDR-style configuration.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#netmask Domain#netmask}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Netmask
        {
            get;
            set;
        }

        /// <summary>Specifies the prefix length for the route (for example, 24 for "192.168.10.0/24" or 64 for "2001:db8::/64"), used instead of netmask for CIDR-style configuration.</summary>
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
