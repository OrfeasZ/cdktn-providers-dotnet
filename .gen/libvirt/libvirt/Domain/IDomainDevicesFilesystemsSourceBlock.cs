using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsSourceBlock), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsSourceBlock")]
    public interface IDomainDevicesFilesystemsSourceBlock
    {
        /// <summary>Sets the path of the host block device (for example `/dev/sdb1`) to use as the backing storage for the filesystem.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        string Dev
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsSourceBlock), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsSourceBlock")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsSourceBlock
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the path of the host block device (for example `/dev/sdb1`) to use as the backing storage for the filesystem.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
            public string Dev
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
