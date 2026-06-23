using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkKnownHosts")]
    public class DomainDevicesDisksBackingStoreSourceNetworkKnownHosts : libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkKnownHosts
    {
        /// <summary>Sets the path to the known-hosts file used to verify the identity of the remote storage host;</summary>
        /// <remarks>
        /// value is a required user-provided filesystem path (for example, /etc/libvirt/known_hosts).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}
