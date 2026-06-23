using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshot")]
    public class DomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshot : libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshot
    {
        /// <summary>Sets the name of the network snapshot to use as the backing store for the mirrored disk’s network source;</summary>
        /// <remarks>
        /// value is user-provided and must match an existing snapshot identifier on the storage backend.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
