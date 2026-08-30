using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceDevice), fullyQualifiedName: "libvirt.pool.PoolSourceDevice")]
    public interface IPoolSourceDevice
    {
        /// <summary>Sets the absolute path of the source block device used by the pool, such as "/dev/sdb" or "/dev/mapper/mpath0".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#path Pool#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Describes one or more free extents on the source device that are available for allocation by the pool, each defined by a start and end offset.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#device-extents">https://libvirt.org/formatstorage.html#device-extents</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#free_extents Pool#free_extents}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Pool.IPoolSourceDeviceFreeExtents" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "freeExtents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.pool.PoolSourceDeviceFreeExtents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FreeExtents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the character used to separate the base device name from partition numbers (for example, "p" for devices like "/dev/nvme0n1p1");</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#part_separator Pool#part_separator}
        /// </remarks>
        [JsiiProperty(name: "partSeparator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartSeparator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceDevice), fullyQualifiedName: "libvirt.pool.PoolSourceDevice")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the absolute path of the source block device used by the pool, such as "/dev/sdb" or "/dev/mapper/mpath0".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#path Pool#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Describes one or more free extents on the source device that are available for allocation by the pool, each defined by a start and end offset.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#device-extents">https://libvirt.org/formatstorage.html#device-extents</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#free_extents Pool#free_extents}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Pool.IPoolSourceDeviceFreeExtents" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "freeExtents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.pool.PoolSourceDeviceFreeExtents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FreeExtents
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the character used to separate the base device name from partition numbers (for example, "p" for devices like "/dev/nvme0n1p1");</summary>
            /// <remarks>
            /// the value is user-provided and backend-specific.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#part_separator Pool#part_separator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partSeparator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartSeparator
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
