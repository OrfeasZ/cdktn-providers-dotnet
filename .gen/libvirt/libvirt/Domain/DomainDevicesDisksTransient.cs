using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksTransient")]
    public class DomainDevicesDisksTransient : libvirt.Domain.IDomainDevicesDisksTransient
    {
        /// <summary>Sets whether a transient disk is allowed to share its backing image with other guests; accepts "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#share_backing Domain#share_backing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shareBacking", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShareBacking
        {
            get;
            set;
        }
    }
}
