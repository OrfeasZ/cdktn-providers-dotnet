using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceDataStoreFormat), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceDataStoreFormat")]
    public interface IDomainDevicesDisksBackingStoreSourceDataStoreFormat
    {
        /// <summary>Sets the data store format type for the mirrored backing store (for example, "qcow2" or "raw");</summary>
        /// <remarks>
        /// the value is user-provided and must be a valid libvirt disk format name.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Configures metadata cache behavior for the mirrored backing store’s data store format (for example, limiting the size of cached metadata).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#metadata_cache Domain#metadata_cache}
        /// </remarks>
        [JsiiProperty(name: "metadataCache", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCache\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCache? MetadataCache
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceDataStoreFormat), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceDataStoreFormat")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksBackingStoreSourceDataStoreFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the data store format type for the mirrored backing store (for example, "qcow2" or "raw");</summary>
            /// <remarks>
            /// the value is user-provided and must be a valid libvirt disk format name.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configures metadata cache behavior for the mirrored backing store’s data store format (for example, limiting the size of cached metadata).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#metadata_cache Domain#metadata_cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadataCache", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCache\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCache? MetadataCache
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCache?>();
            }
        }
    }
}
