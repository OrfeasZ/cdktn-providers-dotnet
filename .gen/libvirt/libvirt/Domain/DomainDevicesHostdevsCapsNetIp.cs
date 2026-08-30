using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsCapsNetIp")]
    public class DomainDevicesHostdevsCapsNetIp : libvirt.Domain.IDomainDevicesHostdevsCapsNetIp
    {
        /// <summary>Sets the IP address assigned to the passthrough network device; value is user-provided (for example, "192.168.122.10" or "2001:db8::10").</summary>
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

        /// <summary>Sets the IP address family for the passthrough network device, typically "ipv4" or "ipv6".</summary>
        /// <remarks>
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

        /// <summary>Sets the CIDR prefix length of the IP address for the passthrough network device, as a non-negative integer (for example, 24 for IPv4 or 64 for IPv6).</summary>
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
