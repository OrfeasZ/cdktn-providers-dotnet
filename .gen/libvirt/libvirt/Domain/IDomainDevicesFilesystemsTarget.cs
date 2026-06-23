using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsTarget")]
    public interface IDomainDevicesFilesystemsTarget
    {
        /// <summary>Sets the guest-visible directory path for the filesystem mount point (for example, "/mnt/share");</summary>
        /// <remarks>
        /// the value is user-provided and must be an absolute path in the guest.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dir Domain#dir}
        /// </remarks>
        [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}")]
        string Dir
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsTarget")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the guest-visible directory path for the filesystem mount point (for example, "/mnt/share");</summary>
            /// <remarks>
            /// the value is user-provided and must be an absolute path in the guest.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dir Domain#dir}
            /// </remarks>
            [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}")]
            public string Dir
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
