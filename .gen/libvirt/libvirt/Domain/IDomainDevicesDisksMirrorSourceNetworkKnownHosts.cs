using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorSourceNetworkKnownHosts), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceNetworkKnownHosts")]
    public interface IDomainDevicesDisksMirrorSourceNetworkKnownHosts
    {
        /// <summary>Sets the path to the known-hosts file used to verify the identity of the remote storage host;</summary>
        /// <remarks>
        /// value is a required user-provided filesystem path (for example, /etc/libvirt/known_hosts).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorSourceNetworkKnownHosts), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceNetworkKnownHosts")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkKnownHosts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the path to the known-hosts file used to verify the identity of the remote storage host;</summary>
            /// <remarks>
            /// value is a required user-provided filesystem path (for example, /etc/libvirt/known_hosts).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
