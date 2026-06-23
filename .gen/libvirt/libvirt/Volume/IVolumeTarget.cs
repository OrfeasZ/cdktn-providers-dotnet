using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiInterface(nativeType: typeof(IVolumeTarget), fullyQualifiedName: "libvirt.volume.VolumeTarget")]
    public interface IVolumeTarget
    {
        /// <summary>Sets the cluster size for qcow2 volumes, controlling the allocation granularity on disk;</summary>
        /// <remarks>
        /// value is a size with the unit given by <c>cluster_size_unit</c>.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#cluster_size Volume#cluster_size}
        /// </remarks>
        [JsiiProperty(name: "clusterSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ClusterSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the unit for `cluster_size` (for example `bytes`, `KiB`, `MiB`), matching libvirt’s clusterSize `unit` attribute semantics.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#cluster_size_unit Volume#cluster_size_unit}
        /// </remarks>
        [JsiiProperty(name: "clusterSizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterSizeUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the qcow2 compatibility level for the volume (for example `0.10` or `1.1`), controlling which qemu feature set the image uses.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#compat Volume#compat}
        /// </remarks>
        [JsiiProperty(name: "compat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Compat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures encryption for the volume’s data, defining the cipher parameters for an encrypted image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#encryption Volume#encryption}
        /// </remarks>
        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeTargetEncryption? Encryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures per-volume feature flags for the target format (such as qcow2 features);</summary>
        /// <remarks>
        /// contents are user-provided according to the image format.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#features Volume#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.volume.VolumeTargetFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the on-disk format metadata for the backing store volume;</summary>
        /// <remarks>
        /// this must match the actual format of the backing image.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#format Volume#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeTargetFormat? Format
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
        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetPermissions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeTargetPermissions? Permissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures stored timestamps for the volume target, such as access and change times.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#timestamps Volume#timestamps}
        /// </remarks>
        [JsiiProperty(name: "timestamps", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetTimestamps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeTargetTimestamps? Timestamps
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVolumeTarget), fullyQualifiedName: "libvirt.volume.VolumeTarget")]
        internal sealed class _Proxy : DeputyBase, libvirt.Volume.IVolumeTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the cluster size for qcow2 volumes, controlling the allocation granularity on disk;</summary>
            /// <remarks>
            /// value is a size with the unit given by <c>cluster_size_unit</c>.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#cluster_size Volume#cluster_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ClusterSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the unit for `cluster_size` (for example `bytes`, `KiB`, `MiB`), matching libvirt’s clusterSize `unit` attribute semantics.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#cluster_size_unit Volume#cluster_size_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterSizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterSizeUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the qcow2 compatibility level for the volume (for example `0.10` or `1.1`), controlling which qemu feature set the image uses.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#compat Volume#compat}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Compat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables and configures encryption for the volume’s data, defining the cipher parameters for an encrypted image.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#encryption Volume#encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryption\"}", isOptional: true)]
            public libvirt.Volume.IVolumeTargetEncryption? Encryption
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeTargetEncryption?>();
            }

            /// <summary>Configures per-volume feature flags for the target format (such as qcow2 features);</summary>
            /// <remarks>
            /// contents are user-provided according to the image format.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#features Volume#features}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.volume.VolumeTargetFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Features
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the on-disk format metadata for the backing store volume;</summary>
            /// <remarks>
            /// this must match the actual format of the backing image.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#format Volume#format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetFormat\"}", isOptional: true)]
            public libvirt.Volume.IVolumeTargetFormat? Format
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeTargetFormat?>();
            }

            /// <summary>Configures POSIX ownership and SELinux label metadata for the backing store volume, controlling how the backing file is labeled and accessed on the host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#permissions Volume#permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetPermissions\"}", isOptional: true)]
            public libvirt.Volume.IVolumeTargetPermissions? Permissions
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeTargetPermissions?>();
            }

            /// <summary>Configures stored timestamps for the volume target, such as access and change times.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#timestamps Volume#timestamps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timestamps", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetTimestamps\"}", isOptional: true)]
            public libvirt.Volume.IVolumeTargetTimestamps? Timestamps
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeTargetTimestamps?>();
            }
        }
    }
}
