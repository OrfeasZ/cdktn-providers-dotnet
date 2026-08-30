using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirror), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirror")]
    public interface IDomainDevicesDisksMirror
    {
        /// <summary>Defines the backing store chain for the mirrored disk image, describing one layer of the underlying image stack used by the mirror target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backing_store Domain#backing_store}
        /// </remarks>
        [JsiiProperty(name: "backingStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStore\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStore? BackingStore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the on-disk format settings for the mirrored backing store’s data store, including format type and optional metadata cache tuning.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorFormat? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the mirroring job mode, such as whether the mirror should be a persistent replacement or a transient copy;</summary>
        /// <remarks>
        /// the value is user-provided and must match a libvirt-supported job type.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#job Domain#job}
        /// </remarks>
        [JsiiProperty(name: "job", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Job
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether the mirror is marked as ready to be switched to or used (typically a yes/no flag as a string, such as "yes" or "no").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ready Domain#ready}
        /// </remarks>
        [JsiiProperty(name: "ready", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ready
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
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirror), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirror")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirror
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines the backing store chain for the mirrored disk image, describing one layer of the underlying image stack used by the mirror target.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backing_store Domain#backing_store}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backingStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStore\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStore? BackingStore
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStore?>();
            }

            /// <summary>Configures the on-disk format settings for the mirrored backing store’s data store, including format type and optional metadata cache tuning.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorFormat\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorFormat? Format
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorFormat?>();
            }

            /// <summary>Selects the mirroring job mode, such as whether the mirror should be a persistent replacement or a transient copy;</summary>
            /// <remarks>
            /// the value is user-provided and must match a libvirt-supported job type.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#job Domain#job}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "job", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Job
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates whether the mirror is marked as ready to be switched to or used (typically a yes/no flag as a string, such as "yes" or "no").</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ready Domain#ready}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ready", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ready
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines the data source for the mirror backing store, such as a block device or file path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorSource?>();
            }
        }
    }
}
