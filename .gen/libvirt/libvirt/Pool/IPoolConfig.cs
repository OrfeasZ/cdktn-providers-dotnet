using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolConfig), fullyQualifiedName: "libvirt.pool.PoolConfig")]
    public interface IPoolConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Sets the storage pool name, which must be unique on the host and is required when defining a pool.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-general-metadata">https://libvirt.org/formatstorage.html#storage-pool-general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#name Pool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Sets the storage pool backend type, such as "dir", "fs", "netfs", "logical", "disk", "iscsi", "scsi", "mpath", or "zfs", which determines which source/target sub-elements are valid.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-xml">https://libvirt.org/formatstorage.html#storage-pool-xml</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#type Pool#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Sets the unit used for the storage_pool.allocation value (for example, "bytes", "KiB", "MiB", "GiB"); if unset, libvirt’s default unit (typically bytes) is used.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-general-metadata">https://libvirt.org/formatstorage.html#storage-pool-general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#allocation_unit Pool#allocation_unit}
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

        /// <summary>Sets the unit used for the storage_pool.available value (for example, "bytes", "KiB", "MiB", "GiB"); if unset, libvirt’s default unit (typically bytes) is used.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-general-metadata">https://libvirt.org/formatstorage.html#storage-pool-general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#available_unit Pool#available_unit}
        /// </remarks>
        [JsiiProperty(name: "availableUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailableUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the unit used for the storage_pool.capacity value (for example, "bytes", "KiB", "MiB", "GiB"); if unset, libvirt’s default unit (typically bytes) is used.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-general-metadata">https://libvirt.org/formatstorage.html#storage-pool-general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#capacity_unit Pool#capacity_unit}
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

        /// <summary>Experimental: provider-specific lifecycle controls for create-time operations after pool definition. Subject to change in future releases.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#create Pool#create}
        /// </remarks>
        [JsiiProperty(name: "create", typeJson: "{\"fqn\":\"libvirt.pool.PoolCreate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolCreate? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Experimental: provider-specific lifecycle controls for delete-time operations beyond undefine. Subject to change in future releases.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#destroy Pool#destroy}
        /// </remarks>
        [JsiiProperty(name: "destroy", typeJson: "{\"fqn\":\"libvirt.pool.PoolDestroy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolDestroy? Destroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables optional storage-pool-specific features such as copy-on-write behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#features Pool#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"libvirt.pool.PoolFeatures\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolFeatures? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#fs_commandline Pool#fs_commandline}.</summary>
        [JsiiProperty(name: "fsCommandline", typeJson: "{\"fqn\":\"libvirt.pool.PoolFsCommandline\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolFsCommandline? FsCommandline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#rbd_commandline Pool#rbd_commandline}.</summary>
        [JsiiProperty(name: "rbdCommandline", typeJson: "{\"fqn\":\"libvirt.pool.PoolRbdCommandline\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolRbdCommandline? RbdCommandline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures optional refresh behavior for the pool and its volumes, controlling how allocation statistics are recomputed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#refresh Pool#refresh}
        /// </remarks>
        [JsiiProperty(name: "refresh", typeJson: "{\"fqn\":\"libvirt.pool.PoolRefresh\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolRefresh? Refresh
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the source backing for the storage pool (e.g., device, host, directory, or network export), specific to the chosen pool type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#source Pool#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.pool.PoolSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolSource? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#target Pool#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.pool.PoolTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolTarget? Target
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolConfig), fullyQualifiedName: "libvirt.pool.PoolConfig")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the storage pool name, which must be unique on the host and is required when defining a pool.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-general-metadata">https://libvirt.org/formatstorage.html#storage-pool-general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#name Pool#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the storage pool backend type, such as "dir", "fs", "netfs", "logical", "disk", "iscsi", "scsi", "mpath", or "zfs", which determines which source/target sub-elements are valid.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-xml">https://libvirt.org/formatstorage.html#storage-pool-xml</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#type Pool#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the unit used for the storage_pool.allocation value (for example, "bytes", "KiB", "MiB", "GiB"); if unset, libvirt’s default unit (typically bytes) is used.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-general-metadata">https://libvirt.org/formatstorage.html#storage-pool-general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#allocation_unit Pool#allocation_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allocationUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the unit used for the storage_pool.available value (for example, "bytes", "KiB", "MiB", "GiB"); if unset, libvirt’s default unit (typically bytes) is used.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-general-metadata">https://libvirt.org/formatstorage.html#storage-pool-general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#available_unit Pool#available_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "availableUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailableUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the unit used for the storage_pool.capacity value (for example, "bytes", "KiB", "MiB", "GiB"); if unset, libvirt’s default unit (typically bytes) is used.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-pool-general-metadata">https://libvirt.org/formatstorage.html#storage-pool-general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#capacity_unit Pool#capacity_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacityUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Experimental: provider-specific lifecycle controls for create-time operations after pool definition. Subject to change in future releases.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#create Pool#create}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"fqn\":\"libvirt.pool.PoolCreate\"}", isOptional: true)]
            public libvirt.Pool.IPoolCreate? Create
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolCreate?>();
            }

            /// <summary>Experimental: provider-specific lifecycle controls for delete-time operations beyond undefine. Subject to change in future releases.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#destroy Pool#destroy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destroy", typeJson: "{\"fqn\":\"libvirt.pool.PoolDestroy\"}", isOptional: true)]
            public libvirt.Pool.IPoolDestroy? Destroy
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolDestroy?>();
            }

            /// <summary>Enables optional storage-pool-specific features such as copy-on-write behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#features Pool#features}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"libvirt.pool.PoolFeatures\"}", isOptional: true)]
            public libvirt.Pool.IPoolFeatures? Features
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolFeatures?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#fs_commandline Pool#fs_commandline}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fsCommandline", typeJson: "{\"fqn\":\"libvirt.pool.PoolFsCommandline\"}", isOptional: true)]
            public libvirt.Pool.IPoolFsCommandline? FsCommandline
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolFsCommandline?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#rbd_commandline Pool#rbd_commandline}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rbdCommandline", typeJson: "{\"fqn\":\"libvirt.pool.PoolRbdCommandline\"}", isOptional: true)]
            public libvirt.Pool.IPoolRbdCommandline? RbdCommandline
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolRbdCommandline?>();
            }

            /// <summary>Configures optional refresh behavior for the pool and its volumes, controlling how allocation statistics are recomputed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#refresh Pool#refresh}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refresh", typeJson: "{\"fqn\":\"libvirt.pool.PoolRefresh\"}", isOptional: true)]
            public libvirt.Pool.IPoolRefresh? Refresh
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolRefresh?>();
            }

            /// <summary>Defines the source backing for the storage pool (e.g., device, host, directory, or network export), specific to the chosen pool type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#source Pool#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.pool.PoolSource\"}", isOptional: true)]
            public libvirt.Pool.IPoolSource? Source
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolSource?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#target Pool#target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.pool.PoolTarget\"}", isOptional: true)]
            public libvirt.Pool.IPoolTarget? Target
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolTarget?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
