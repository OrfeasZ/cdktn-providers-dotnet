using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainFeaturesHyperVTlbFlush")]
    public class DomainFeaturesHyperVTlbFlush : libvirt.Domain.IDomainFeaturesHyperVTlbFlush
    {
        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#direct Domain#direct}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direct", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlushDirect\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesHyperVTlbFlushDirect? Direct
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#extended Domain#extended}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extended", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlushExtended\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesHyperVTlbFlushExtended? Extended
        {
            get;
            set;
        }

        /// <summary>Sets the PS2 feature state;</summary>
        /// <remarks>
        /// valid values are usually "on" or "off" to enable or disable the PS/2-related feature for the domain.
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
