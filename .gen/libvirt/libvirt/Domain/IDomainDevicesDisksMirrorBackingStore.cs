using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorBackingStore), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStore")]
    public interface IDomainDevicesDisksMirrorBackingStore
    {
        /// <summary>Configures the on-disk format settings for the mirrored backing store’s data store, including format type and optional metadata cache tuning.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreFormat? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the index of this backing store within the mirror’s backing chain, as an integer used to order multiple backingStore entries.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#index Domain#index}
        /// </remarks>
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Index
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the data source for the mirror backing store, such as a block device or file path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorBackingStore), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStore")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorBackingStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the on-disk format settings for the mirrored backing store’s data store, including format type and optional metadata cache tuning.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreFormat\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreFormat? Format
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreFormat?>();
            }

            /// <summary>Sets the index of this backing store within the mirror’s backing chain, as an integer used to order multiple backingStore entries.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#index Domain#index}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Index
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Defines the data source for the mirror backing store, such as a block device or file path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSource?>();
            }
        }
    }
}
