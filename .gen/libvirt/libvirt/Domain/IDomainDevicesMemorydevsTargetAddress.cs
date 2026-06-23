using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesMemorydevsTargetAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesMemorydevsTargetAddress")]
    public interface IDomainDevicesMemorydevsTargetAddress
    {
        /// <summary>Sets the base guest physical address for this memory device in hexadecimal or numeric form (for example, "0x140000000" or "5368709120"), determining where the memory is mapped in the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#base Domain#base}
        /// </remarks>
        [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Base
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesMemorydevsTargetAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesMemorydevsTargetAddress")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesMemorydevsTargetAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the base guest physical address for this memory device in hexadecimal or numeric form (for example, "0x140000000" or "5368709120"), determining where the memory is mapped in the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#base Domain#base}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Base
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
