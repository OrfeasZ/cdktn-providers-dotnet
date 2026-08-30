using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsSourceVolume), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsSourceVolume")]
    public interface IDomainDevicesFilesystemsSourceVolume
    {
        /// <summary>Sets the name of the storage pool that contains the volume used as the filesystem source;</summary>
        /// <remarks>
        /// the value is user-provided and must match an existing pool (for example, "default").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pool Domain#pool}
        /// </remarks>
        [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}")]
        string Pool
        {
            get;
        }

        /// <summary>Sets the name of the storage volume within the specified pool to expose as the filesystem source (for example, "myshare.img"); the value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#volume Domain#volume}
        /// </remarks>
        [JsiiProperty(name: "volume", typeJson: "{\"primitive\":\"string\"}")]
        string Volume
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsSourceVolume), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsSourceVolume")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsSourceVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the name of the storage pool that contains the volume used as the filesystem source;</summary>
            /// <remarks>
            /// the value is user-provided and must match an existing pool (for example, "default").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pool Domain#pool}
            /// </remarks>
            [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}")]
            public string Pool
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the name of the storage volume within the specified pool to expose as the filesystem source (for example, "myshare.img"); the value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#volume Domain#volume}
            /// </remarks>
            [JsiiProperty(name: "volume", typeJson: "{\"primitive\":\"string\"}")]
            public string Volume
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
