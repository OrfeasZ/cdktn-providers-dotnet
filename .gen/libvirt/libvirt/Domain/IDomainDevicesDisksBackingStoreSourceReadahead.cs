using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceReadahead), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceReadahead")]
    public interface IDomainDevicesDisksBackingStoreSourceReadahead
    {
        /// <summary>Sets the read-ahead size for the mirrored disk’s backing store;</summary>
        /// <remarks>
        /// value is a user-provided positive integer in bytes (for example, 65536 for 64 KiB).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
        string Size
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceReadahead), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceReadahead")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReadahead
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the read-ahead size for the mirrored disk’s backing store;</summary>
            /// <remarks>
            /// value is a user-provided positive integer in bytes (for example, 65536 for 64 KiB).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
            /// </remarks>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
            public string Size
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
