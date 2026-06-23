using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksSourceReadahead")]
    public class DomainDevicesDisksSourceReadahead : libvirt.Domain.IDomainDevicesDisksSourceReadahead
    {
        /// <summary>Sets the read-ahead size for the mirrored disk’s backing store;</summary>
        /// <remarks>
        /// value is a user-provided positive integer in bytes (for example, 65536 for 64 KiB).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
        public string Size
        {
            get;
            set;
        }
    }
}
