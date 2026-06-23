using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksBackingStoreSourceTimeout")]
    public class DomainDevicesDisksBackingStoreSourceTimeout : libvirt.Domain.IDomainDevicesDisksBackingStoreSourceTimeout
    {
        /// <summary>Sets the timeout duration in seconds for accessing the mirrored backing-store source; must be a non‑negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#seconds Domain#seconds}
        /// </remarks>
        [JsiiProperty(name: "seconds", typeJson: "{\"primitive\":\"string\"}")]
        public string Seconds
        {
            get;
            set;
        }
    }
}
