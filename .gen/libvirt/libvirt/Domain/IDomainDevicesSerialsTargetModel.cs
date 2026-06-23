using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesSerialsTargetModel), fullyQualifiedName: "libvirt.domain.DomainDevicesSerialsTargetModel")]
    public interface IDomainDevicesSerialsTargetModel
    {
        /// <summary>Sets the serial controller model name (user-provided string, e.g. "isa-serial" or "pci-serial"), as accepted by the underlying hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesSerialsTargetModel), fullyQualifiedName: "libvirt.domain.DomainDevicesSerialsTargetModel")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesSerialsTargetModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the serial controller model name (user-provided string, e.g. "isa-serial" or "pci-serial"), as accepted by the underlying hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
