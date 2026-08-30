using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorSourceDataStore), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceDataStore")]
    public interface IDomainDevicesDisksMirrorSourceDataStore
    {
        /// <summary>Configures the on-disk format settings for the mirrored backing store’s data store, including format type and optional metadata cache tuning.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceDataStoreFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorSourceDataStoreFormat? Format
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorSourceDataStore), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceDataStore")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorSourceDataStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the on-disk format settings for the mirrored backing store’s data store, including format type and optional metadata cache tuning.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceDataStoreFormat\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorSourceDataStoreFormat? Format
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorSourceDataStoreFormat?>();
            }
        }
    }
}
