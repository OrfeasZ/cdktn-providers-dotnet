using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainFeaturesIoapic")]
    public class DomainFeaturesIoapic : libvirt.Domain.IDomainFeaturesIoapic
    {
        /// <summary>Selects the IOAPIC emulation driver, typically using values like "qemu" or "kvm";</summary>
        /// <remarks>
        /// the exact string is user-provided but must be supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Driver
        {
            get;
            set;
        }
    }
}
