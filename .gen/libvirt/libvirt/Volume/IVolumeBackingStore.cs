using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiInterface(nativeType: typeof(IVolumeBackingStore), fullyQualifiedName: "libvirt.volume.VolumeBackingStore")]
    public interface IVolumeBackingStore
    {
        /// <summary>Sets the path to the backing image used by this volume, either as an absolute host path or a pool-relative path (for example, "/var/lib/libvirt/images/base.qcow2").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#backing-store-elements">https://libvirt.org/formatstorage.html#backing-store-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#path Volume#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Sets the on-disk format metadata for the backing store volume;</summary>
        /// <remarks>
        /// this must match the actual format of the backing image.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#format Volume#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.volume.VolumeBackingStoreFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeBackingStoreFormat? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures POSIX ownership and SELinux label metadata for the backing store volume, controlling how the backing file is labeled and accessed on the host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#permissions Volume#permissions}
        /// </remarks>
        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"libvirt.volume.VolumeBackingStorePermissions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeBackingStorePermissions? Permissions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVolumeBackingStore), fullyQualifiedName: "libvirt.volume.VolumeBackingStore")]
        internal sealed class _Proxy : DeputyBase, libvirt.Volume.IVolumeBackingStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the path to the backing image used by this volume, either as an absolute host path or a pool-relative path (for example, "/var/lib/libvirt/images/base.qcow2").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#backing-store-elements">https://libvirt.org/formatstorage.html#backing-store-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#path Volume#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the on-disk format metadata for the backing store volume;</summary>
            /// <remarks>
            /// this must match the actual format of the backing image.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#format Volume#format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.volume.VolumeBackingStoreFormat\"}", isOptional: true)]
            public libvirt.Volume.IVolumeBackingStoreFormat? Format
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeBackingStoreFormat?>();
            }

            /// <summary>Configures POSIX ownership and SELinux label metadata for the backing store volume, controlling how the backing file is labeled and accessed on the host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#permissions Volume#permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"libvirt.volume.VolumeBackingStorePermissions\"}", isOptional: true)]
            public libvirt.Volume.IVolumeBackingStorePermissions? Permissions
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeBackingStorePermissions?>();
            }
        }
    }
}
