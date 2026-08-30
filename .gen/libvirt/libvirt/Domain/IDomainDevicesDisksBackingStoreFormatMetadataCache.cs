using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksBackingStoreFormatMetadataCache), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreFormatMetadataCache")]
    public interface IDomainDevicesDisksBackingStoreFormatMetadataCache
    {
        /// <summary>Sets the maximum size of the metadata cache used by the data store format;</summary>
        /// <remarks>
        /// value and unit together define the limit (for example, 64 MiB).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_size Domain#max_size}
        /// </remarks>
        [JsiiProperty(name: "maxSize", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreFormatMetadataCacheMaxSize\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksBackingStoreFormatMetadataCacheMaxSize? MaxSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksBackingStoreFormatMetadataCache), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreFormatMetadataCache")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksBackingStoreFormatMetadataCache
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the maximum size of the metadata cache used by the data store format;</summary>
            /// <remarks>
            /// value and unit together define the limit (for example, 64 MiB).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_size Domain#max_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxSize", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreFormatMetadataCacheMaxSize\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksBackingStoreFormatMetadataCacheMaxSize? MaxSize
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksBackingStoreFormatMetadataCacheMaxSize?>();
            }
        }
    }
}
