using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.pool.PoolSourceDevice")]
    public class PoolSourceDevice : libvirt.Pool.IPoolSourceDevice
    {
        /// <summary>Sets the absolute path of the source block device used by the pool, such as "/dev/sdb" or "/dev/mapper/mpath0".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#path Pool#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        private object? _freeExtents;

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
            get => _freeExtents;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Pool.IPoolSourceDeviceFreeExtents[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolSourceDeviceFreeExtents).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _freeExtents = value;
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
        [JsiiOptional]
        [JsiiProperty(name: "partSeparator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PartSeparator
        {
            get;
            set;
        }
    }
}
