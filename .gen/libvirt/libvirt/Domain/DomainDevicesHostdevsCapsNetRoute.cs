using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsCapsNetRoute")]
    public class DomainDevicesHostdevsCapsNetRoute : libvirt.Domain.IDomainDevicesHostdevsCapsNetRoute
    {
        /// <summary>Sets the destination network address for the static route associated with the passthrough host device;</summary>
        /// <remarks>
        /// value is user-provided (for example, "10.0.0.0").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Sets the address family for the static route, typically "ipv4" or "ipv6".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#family Domain#family}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Family
        {
            get;
            set;
        }

        /// <summary>Sets the gateway IP address used to reach the route destination network via the passthrough device; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gateway Domain#gateway}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Gateway
        {
            get;
            set;
        }
    }
}
