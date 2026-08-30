using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainPm), fullyQualifiedName: "libvirt.domain.DomainPm")]
    public interface IDomainPm
    {
        /// <summary>Configures whether the guest firmware advertises S4 (suspend-to-disk / hibernate) capability to the guest OS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#suspend_to_disk Domain#suspend_to_disk}
        /// </remarks>
        [JsiiProperty(name: "suspendToDisk", typeJson: "{\"fqn\":\"libvirt.domain.DomainPmSuspendToDisk\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainPmSuspendToDisk? SuspendToDisk
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures whether the guest firmware advertises S4 (suspend-to-disk / hibernate) capability to the guest OS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#suspend_to_mem Domain#suspend_to_mem}
        /// </remarks>
        [JsiiProperty(name: "suspendToMem", typeJson: "{\"fqn\":\"libvirt.domain.DomainPmSuspendToMem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainPmSuspendToMem? SuspendToMem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainPm), fullyQualifiedName: "libvirt.domain.DomainPm")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainPm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures whether the guest firmware advertises S4 (suspend-to-disk / hibernate) capability to the guest OS.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#suspend_to_disk Domain#suspend_to_disk}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suspendToDisk", typeJson: "{\"fqn\":\"libvirt.domain.DomainPmSuspendToDisk\"}", isOptional: true)]
            public libvirt.Domain.IDomainPmSuspendToDisk? SuspendToDisk
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainPmSuspendToDisk?>();
            }

            /// <summary>Configures whether the guest firmware advertises S4 (suspend-to-disk / hibernate) capability to the guest OS.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#suspend_to_mem Domain#suspend_to_mem}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suspendToMem", typeJson: "{\"fqn\":\"libvirt.domain.DomainPmSuspendToMem\"}", isOptional: true)]
            public libvirt.Domain.IDomainPmSuspendToMem? SuspendToMem
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainPmSuspendToMem?>();
            }
        }
    }
}
