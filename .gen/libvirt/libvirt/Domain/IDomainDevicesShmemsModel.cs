using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesShmemsModel), fullyQualifiedName: "libvirt.domain.DomainDevicesShmemsModel")]
    public interface IDomainDevicesShmemsModel
    {
        /// <summary>Sets the shared memory model type; valid values include "ivshmem-plain" and "ivshmem-doorbell" as supported by QEMU.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesShmemsModel), fullyQualifiedName: "libvirt.domain.DomainDevicesShmemsModel")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesShmemsModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the shared memory model type; valid values include "ivshmem-plain" and "ivshmem-doorbell" as supported by QEMU.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
