using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsNvRamSourceNetworkSnapshot), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceNetworkSnapshot")]
    public interface IDomainOsNvRamSourceNetworkSnapshot
    {
        /// <summary>Sets the name of the network snapshot to use as the backing store for the mirrored disk’s network source;</summary>
        /// <remarks>
        /// value is user-provided and must match an existing snapshot identifier on the storage backend.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsNvRamSourceNetworkSnapshot), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceNetworkSnapshot")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsNvRamSourceNetworkSnapshot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the name of the network snapshot to use as the backing store for the mirrored disk’s network source;</summary>
            /// <remarks>
            /// value is user-provided and must match an existing snapshot identifier on the storage backend.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
