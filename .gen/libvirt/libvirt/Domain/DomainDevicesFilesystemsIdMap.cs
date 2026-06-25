using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsIdMap")]
    public class DomainDevicesFilesystemsIdMap : libvirt.Domain.IDomainDevicesFilesystemsIdMap
    {
        private object? _gid;

        /// <summary>Defines one or more group ID (GID) mapping ranges for the filesystem, remapping guest GIDs to host GIDs according to the attributes provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gid Domain#gid}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesFilesystemsIdMapGid" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gid", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsIdMapGid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Gid
        {
            get => _gid;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesFilesystemsIdMapGid[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesFilesystemsIdMapGid).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _gid = value;
            }
        }

        private object? _uid;

        /// <summary>Defines one or more user ID (UID) mapping ranges for the filesystem, remapping guest UIDs to host UIDs via count/start/target attributes similar to gid mapping.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#uid Domain#uid}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesFilesystemsIdMapUid" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uid", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsIdMapUid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Uid
        {
            get => _uid;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesFilesystemsIdMapUid[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesFilesystemsIdMapUid).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _uid = value;
            }
        }
    }
}
