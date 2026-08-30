using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiByValue(fqn: "libvirt.volume.VolumeTarget")]
    public class VolumeTarget : libvirt.Volume.IVolumeTarget
    {
        /// <summary>Sets the cluster size for qcow2 volumes, controlling the allocation granularity on disk;</summary>
        /// <remarks>
        /// value is a size with the unit given by <c>cluster_size_unit</c>.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#cluster_size Volume#cluster_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ClusterSize
        {
            get;
            set;
        }

        /// <summary>Sets the unit for `cluster_size` (for example `bytes`, `KiB`, `MiB`), matching libvirt’s clusterSize `unit` attribute semantics.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#cluster_size_unit Volume#cluster_size_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterSizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterSizeUnit
        {
            get;
            set;
        }

        /// <summary>Sets the qcow2 compatibility level for the volume (for example `0.10` or `1.1`), controlling which qemu feature set the image uses.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#compat Volume#compat}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Compat
        {
            get;
            set;
        }

        /// <summary>Enables and configures encryption for the volume’s data, defining the cipher parameters for an encrypted image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#encryption Volume#encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryption\"}", isOptional: true)]
        public libvirt.Volume.IVolumeTargetEncryption? Encryption
        {
            get;
            set;
        }

        private object? _features;

        /// <summary>Configures per-volume feature flags for the target format (such as qcow2 features);</summary>
        /// <remarks>
        /// contents are user-provided according to the image format.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#features Volume#features}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Volume.IVolumeTargetFeatures" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.volume.VolumeTargetFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Features
        {
            get => _features;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Volume.IVolumeTargetFeatures[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Volume.IVolumeTargetFeatures).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _features = value;
            }
        }

        /// <summary>Sets the on-disk format metadata for the backing store volume;</summary>
        /// <remarks>
        /// this must match the actual format of the backing image.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#format Volume#format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetFormat\"}", isOptional: true)]
        public libvirt.Volume.IVolumeTargetFormat? Format
        {
            get;
            set;
        }

        /// <summary>Configures POSIX ownership and SELinux label metadata for the backing store volume, controlling how the backing file is labeled and accessed on the host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#permissions Volume#permissions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetPermissions\"}", isOptional: true)]
        public libvirt.Volume.IVolumeTargetPermissions? Permissions
        {
            get;
            set;
        }

        /// <summary>Configures stored timestamps for the volume target, such as access and change times.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#timestamps Volume#timestamps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timestamps", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetTimestamps\"}", isOptional: true)]
        public libvirt.Volume.IVolumeTargetTimestamps? Timestamps
        {
            get;
            set;
        }
    }
}
