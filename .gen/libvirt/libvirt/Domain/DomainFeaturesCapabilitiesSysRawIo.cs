using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainFeaturesCapabilitiesSysRawIo")]
    public class DomainFeaturesCapabilitiesSysRawIo : libvirt.Domain.IDomainFeaturesCapabilitiesSysRawIo
    {
        /// <summary>Sets whether the guest is allowed to use the host wake alarm capability;</summary>
        /// <remarks>
        /// accepts the usual feature state values such as "on", "off", or "default" depending on hypervisor support.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#state Domain#state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }
    }
}
