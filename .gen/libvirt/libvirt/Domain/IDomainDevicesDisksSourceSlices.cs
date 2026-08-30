using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksSourceSlices), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceSlices")]
    public interface IDomainDevicesDisksSourceSlices
    {
        /// <summary>Configures one or more slices of the backing-store source, each describing a contiguous portion of the underlying device or file that is exposed through this mirror backing store.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#slices Domain#slices}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksSourceSlicesSlices" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "slices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceSlicesSlices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Slices
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksSourceSlices), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceSlices")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksSourceSlices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures one or more slices of the backing-store source, each describing a contiguous portion of the underlying device or file that is exposed through this mirror backing store.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#slices Domain#slices}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksSourceSlicesSlices" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceSlicesSlices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Slices
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
