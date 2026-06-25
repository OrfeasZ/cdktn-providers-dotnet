using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsIdMap), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsIdMap")]
    public interface IDomainDevicesFilesystemsIdMap
    {
        /// <summary>Defines one or more group ID (GID) mapping ranges for the filesystem, remapping guest GIDs to host GIDs according to the attributes provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gid Domain#gid}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesFilesystemsIdMapGid" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "gid", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsIdMapGid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Gid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more user ID (UID) mapping ranges for the filesystem, remapping guest UIDs to host UIDs via count/start/target attributes similar to gid mapping.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#uid Domain#uid}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesFilesystemsIdMapUid" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsIdMapUid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Uid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsIdMap), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsIdMap")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsIdMap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<object?>();
            }

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
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
