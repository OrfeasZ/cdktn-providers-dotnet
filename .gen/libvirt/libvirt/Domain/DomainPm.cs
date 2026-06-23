using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainPm")]
    public class DomainPm : libvirt.Domain.IDomainPm
    {
        /// <summary>Configures whether the guest firmware advertises S4 (suspend-to-disk / hibernate) capability to the guest OS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#suspend_to_disk Domain#suspend_to_disk}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "suspendToDisk", typeJson: "{\"fqn\":\"libvirt.domain.DomainPmSuspendToDisk\"}", isOptional: true)]
        public libvirt.Domain.IDomainPmSuspendToDisk? SuspendToDisk
        {
            get;
            set;
        }

        /// <summary>Configures whether the guest firmware advertises S4 (suspend-to-disk / hibernate) capability to the guest OS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#suspend_to_mem Domain#suspend_to_mem}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "suspendToMem", typeJson: "{\"fqn\":\"libvirt.domain.DomainPmSuspendToMem\"}", isOptional: true)]
        public libvirt.Domain.IDomainPmSuspendToMem? SuspendToMem
        {
            get;
            set;
        }
    }
}
