using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCache")]
    public class DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCache : libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCache
    {
        /// <summary>Sets the maximum size of the metadata cache used by the data store format;</summary>
        /// <remarks>
        /// value and unit together define the limit (for example, 64 MiB).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_size Domain#max_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxSize", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize? MaxSize
        {
            get;
            set;
        }
    }
}
