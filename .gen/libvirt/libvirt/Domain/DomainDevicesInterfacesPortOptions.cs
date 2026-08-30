using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesPortOptions")]
    public class DomainDevicesInterfacesPortOptions : libvirt.Domain.IDomainDevicesInterfacesPortOptions
    {
        /// <summary>Controls whether this interface’s traffic is isolated from other guests on the same virtual network;</summary>
        /// <remarks>
        /// boolean-like string where "yes" isolates and "no" (or omission) does not.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#isolating-guests-network-traffic-from-each-other">https://libvirt.org/formatdomain.html#isolating-guests-network-traffic-from-each-other</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#isolated Domain#isolated}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isolated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Isolated
        {
            get;
            set;
        }
    }
}
