using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesGuest")]
    public class DomainDevicesInterfacesGuest : libvirt.Domain.IDomainDevicesInterfacesGuest
    {
        /// <summary>Sets the actual interface name inside the guest when it differs from the nominal guest.dev name; value is user-provided (for example, "ens3").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#actual Domain#actual}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "actual", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Actual
        {
            get;
            set;
        }

        /// <summary>Sets the guest-visible network interface name (e.g. Linux device name) for this NIC; value is user-provided (for example, "eth0").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dev
        {
            get;
            set;
        }
    }
}
