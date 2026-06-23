using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDir")]
    public class DomainDevicesDisksMirrorBackingStoreSourceDir : libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDir
    {
        /// <summary>Sets the host directory path used as the mirrored backing store source;</summary>
        /// <remarks>
        /// this must be an absolute path on the host (for example, "/var/lib/libvirt/images").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dir Domain#dir}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dir
        {
            get;
            set;
        }
    }
}
