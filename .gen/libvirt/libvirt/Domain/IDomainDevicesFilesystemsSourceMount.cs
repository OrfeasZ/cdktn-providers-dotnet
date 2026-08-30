using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsSourceMount), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsSourceMount")]
    public interface IDomainDevicesFilesystemsSourceMount
    {
        /// <summary>Sets the host directory that is already mounted and will be exposed directly to the guest as the filesystem source.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dir Domain#dir}
        /// </remarks>
        [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dir
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the path of a host socket associated with the mount-based filesystem source (for example a virtio-fs daemon socket);</summary>
        /// <remarks>
        /// value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#socket Domain#socket}
        /// </remarks>
        [JsiiProperty(name: "socket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Socket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsSourceMount), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsSourceMount")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsSourceMount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the host directory that is already mounted and will be exposed directly to the guest as the filesystem source.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dir Domain#dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dir
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the path of a host socket associated with the mount-based filesystem source (for example a virtio-fs daemon socket);</summary>
            /// <remarks>
            /// value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#socket Domain#socket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "socket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Socket
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
