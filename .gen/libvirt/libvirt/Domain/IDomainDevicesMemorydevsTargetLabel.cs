using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesMemorydevsTargetLabel), fullyQualifiedName: "libvirt.domain.DomainDevicesMemorydevsTargetLabel")]
    public interface IDomainDevicesMemorydevsTargetLabel
    {
        /// <summary>Sets the size of the label region associated with this memory device target;</summary>
        /// <remarks>
        /// value is user-provided and interpreted together with <c>label.size_unit</c>.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Size
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the unit for `label.size` (for example `KiB`, `MiB`, `GiB`); the raw value is user-provided and passed directly to libvirt.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size_unit Domain#size_unit}
        /// </remarks>
        [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SizeUnit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesMemorydevsTargetLabel), fullyQualifiedName: "libvirt.domain.DomainDevicesMemorydevsTargetLabel")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesMemorydevsTargetLabel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the size of the label region associated with this memory device target;</summary>
            /// <remarks>
            /// value is user-provided and interpreted together with <c>label.size_unit</c>.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Size
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the unit for `label.size` (for example `KiB`, `MiB`, `GiB`); the raw value is user-provided and passed directly to libvirt.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size_unit Domain#size_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SizeUnit
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
