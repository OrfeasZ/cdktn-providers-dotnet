using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainFeaturesKvmDirtyRing")]
    public class DomainFeaturesKvmDirtyRing : libvirt.Domain.IDomainFeaturesKvmDirtyRing
    {
        /// <summary>Sets the size of the KVM dirty-ring buffer used for memory dirty tracking;</summary>
        /// <remarks>
        /// the value is user-provided and must be a positive integer representing the number of slots in the ring (exact limits depend on the host kernel/QEMU).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Size
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
