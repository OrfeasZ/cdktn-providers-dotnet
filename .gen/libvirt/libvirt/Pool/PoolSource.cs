using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiByValue(fqn: "libvirt.pool.PoolSource")]
    public class PoolSource : libvirt.Pool.IPoolSource
    {
        /// <summary>Configures an HBA/adapter description for pools that use host adapters (e.g., iSCSI or SCSI pools), including addressing and management attributes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#adapter Pool#adapter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adapter", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceAdapter\"}", isOptional: true)]
        public libvirt.Pool.IPoolSourceAdapter? Adapter
        {
            get;
            set;
        }

        /// <summary>Configures optional authentication for the pool source (e.g., user/secret for iSCSI, RBD, or other networked storage), with credentials defined according to the backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#auth Pool#auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceAuth\"}", isOptional: true)]
        public libvirt.Pool.IPoolSourceAuth? Auth
        {
            get;
            set;
        }

        private object? _device;

        /// <summary>Configures a source block device used by the storage pool (for example, for disk, logical, iscsi, or scsi pools), including its path and optional partitioning/extents metadata.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#device Pool#device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "device", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.pool.PoolSourceDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Device
        {
            get => _device;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Pool.IPoolSourceDevice[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolSourceDevice).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _device = value;
            }
        }

        /// <summary>Configures a source directory used by the storage pool backend (for example, for dir, fs, netfs, or vstorage-style pools).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#dir Pool#dir}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceDir\"}", isOptional: true)]
        public libvirt.Pool.IPoolSourceDir? Dir
        {
            get;
            set;
        }

        /// <summary>Declares the low-level format of the pool source, where supported (for example, the filesystem type or protocol-specific format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#format Pool#format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceFormat\"}", isOptional: true)]
        public libvirt.Pool.IPoolSourceFormat? Format
        {
            get;
            set;
        }

        private object? _host;

        /// <summary>Configures a remote host used as the source of the storage pool, including hostname and optional port (for example, an NFS or iSCSI server).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#host Pool#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.pool.PoolSourceHost\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Host
        {
            get => _host;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Pool.IPoolSourceHost[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolSourceHost).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _host = value;
            }
        }

        /// <summary>Configures iSCSI initiator information for the pool source, allowing the host to identify itself to an iSCSI target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#initiator Pool#initiator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceInitiator\"}", isOptional: true)]
        public libvirt.Pool.IPoolSourceInitiator? Initiator
        {
            get;
            set;
        }

        /// <summary>Sets an optional human-readable name for the storage pool source, whose semantics depend on the specific pool type and are otherwise user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#name Pool#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Enables specifying a product descriptor for the storage pool source, typically used together with vendor information for device-based pools.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#product Pool#product}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceProduct\"}", isOptional: true)]
        public libvirt.Pool.IPoolSourceProduct? Product
        {
            get;
            set;
        }

        /// <summary>Enables defining a network storage protocol block for the pool source (for example, RBD, Gluster, or other supported protocols), with details provided by its child attributes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#protocol Pool#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceProtocol\"}", isOptional: true)]
        public libvirt.Pool.IPoolSourceProtocol? Protocol
        {
            get;
            set;
        }

        /// <summary>Enables specifying a vendor descriptor for the storage pool source, typically paired with a product to identify the backing storage hardware.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#vendor Pool#vendor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vendor", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceVendor\"}", isOptional: true)]
        public libvirt.Pool.IPoolSourceVendor? Vendor
        {
            get;
            set;
        }
    }
}
