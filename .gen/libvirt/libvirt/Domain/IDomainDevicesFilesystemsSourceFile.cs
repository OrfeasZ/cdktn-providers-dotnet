using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsSourceFile), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsSourceFile")]
    public interface IDomainDevicesFilesystemsSourceFile
    {
        /// <summary>Sets the path of the host file to be used as the filesystem source (for example `/var/lib/images/rootfs.img`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        string File
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsSourceFile), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsSourceFile")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsSourceFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the path of the host file to be used as the filesystem source (for example `/var/lib/images/rootfs.img`).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
            /// </remarks>
            [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
            public string File
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
