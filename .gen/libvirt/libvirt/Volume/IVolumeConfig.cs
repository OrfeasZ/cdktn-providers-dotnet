using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiInterface(nativeType: typeof(IVolumeConfig), fullyQualifiedName: "libvirt.volume.VolumeConfig")]
    public interface IVolumeConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Sets the volume name, which must be unique within the containing pool (for disk pools, often derived from a device path plus partition index).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-general-metadata">https://libvirt.org/formatstorage.html#storage-volume-general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#name Volume#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Name of the storage pool where the volume will be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#pool Volume#pool}
        /// </remarks>
        [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}")]
        string Pool
        {
            get;
        }

        /// <summary>Sets the unit for the allocation value (for example, "bytes", "KiB", "MiB", "GiB");</summary>
        /// <remarks>
        /// if omitted, libvirt uses its default unit semantics.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-general-metadata">https://libvirt.org/formatstorage.html#storage-volume-general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#allocation_unit Volume#allocation_unit}
        /// </remarks>
        [JsiiProperty(name: "allocationUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllocationUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an optional backing store volume for copy-on-write images, enabling layered storage where this volume records changes on top of another image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#backing_store Volume#backing_store}
        /// </remarks>
        [JsiiProperty(name: "backingStore", typeJson: "{\"fqn\":\"libvirt.volume.VolumeBackingStore\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeBackingStore? BackingStore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Volume capacity in bytes (required unless using create.content).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#capacity Volume#capacity}
        /// </remarks>
        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Capacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the unit used for `capacity` (for example `bytes`, `KiB`, `MiB`, `GiB`), matching libvirt’s `unit` attribute semantics.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-general-metadata">https://libvirt.org/formatstorage.html#storage-volume-general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#capacity_unit Volume#capacity_unit}
        /// </remarks>
        [JsiiProperty(name: "capacityUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Volume creation options for initializing volume content from external sources.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#create Volume#create}
        /// </remarks>
        [JsiiProperty(name: "create", typeJson: "{\"fqn\":\"libvirt.volume.VolumeCreate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeCreate? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the unit used for `physical` (for example `bytes`, `KiB`, `MiB`, `GiB`), matching libvirt’s `unit` attribute semantics.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-general-metadata">https://libvirt.org/formatstorage.html#storage-volume-general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#physical_unit Volume#physical_unit}
        /// </remarks>
        [JsiiProperty(name: "physicalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PhysicalUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#target Volume#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Volume.IVolumeTarget? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the actual storage volume type reported by libvirt (for example `file`, `block`, `dir`, `network`, `netdir`, or `ploop`), matching the `type` attribute libvirt exposes for the volume;</summary>
        /// <remarks>
        /// the value is user-provided and should be consistent with the underlying storage backend.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-xml">https://libvirt.org/formatstorage.html#storage-volume-xml</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#type Volume#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVolumeConfig), fullyQualifiedName: "libvirt.volume.VolumeConfig")]
        internal sealed class _Proxy : DeputyBase, libvirt.Volume.IVolumeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the volume name, which must be unique within the containing pool (for disk pools, often derived from a device path plus partition index).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-general-metadata">https://libvirt.org/formatstorage.html#storage-volume-general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#name Volume#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the storage pool where the volume will be created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#pool Volume#pool}
            /// </remarks>
            [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}")]
            public string Pool
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the unit for the allocation value (for example, "bytes", "KiB", "MiB", "GiB");</summary>
            /// <remarks>
            /// if omitted, libvirt uses its default unit semantics.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-general-metadata">https://libvirt.org/formatstorage.html#storage-volume-general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#allocation_unit Volume#allocation_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allocationUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures an optional backing store volume for copy-on-write images, enabling layered storage where this volume records changes on top of another image.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#backing_store Volume#backing_store}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backingStore", typeJson: "{\"fqn\":\"libvirt.volume.VolumeBackingStore\"}", isOptional: true)]
            public libvirt.Volume.IVolumeBackingStore? BackingStore
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeBackingStore?>();
            }

            /// <summary>Volume capacity in bytes (required unless using create.content).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#capacity Volume#capacity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Capacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the unit used for `capacity` (for example `bytes`, `KiB`, `MiB`, `GiB`), matching libvirt’s `unit` attribute semantics.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-general-metadata">https://libvirt.org/formatstorage.html#storage-volume-general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#capacity_unit Volume#capacity_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacityUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Volume creation options for initializing volume content from external sources.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#create Volume#create}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"fqn\":\"libvirt.volume.VolumeCreate\"}", isOptional: true)]
            public libvirt.Volume.IVolumeCreate? Create
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeCreate?>();
            }

            /// <summary>Sets the unit used for `physical` (for example `bytes`, `KiB`, `MiB`, `GiB`), matching libvirt’s `unit` attribute semantics.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-general-metadata">https://libvirt.org/formatstorage.html#storage-volume-general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#physical_unit Volume#physical_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "physicalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PhysicalUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#target Volume#target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTarget\"}", isOptional: true)]
            public libvirt.Volume.IVolumeTarget? Target
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeTarget?>();
            }

            /// <summary>Sets the actual storage volume type reported by libvirt (for example `file`, `block`, `dir`, `network`, `netdir`, or `ploop`), matching the `type` attribute libvirt exposes for the volume;</summary>
            /// <remarks>
            /// the value is user-provided and should be consistent with the underlying storage backend.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-xml">https://libvirt.org/formatstorage.html#storage-volume-xml</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#type Volume#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
