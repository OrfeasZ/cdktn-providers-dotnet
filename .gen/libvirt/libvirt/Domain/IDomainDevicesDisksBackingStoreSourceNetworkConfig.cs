using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceNetworkConfig), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkConfig")]
    public interface IDomainDevicesDisksBackingStoreSourceNetworkConfig
    {
        /// <summary>Sets the path to the configuration file used for the network backing store connection, such as a Ceph configuration file (/etc/ceph/ceph.conf).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        string File
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceNetworkConfig), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkConfig")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the path to the configuration file used for the network backing store connection, such as a Ceph configuration file (/etc/ceph/ceph.conf).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
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
