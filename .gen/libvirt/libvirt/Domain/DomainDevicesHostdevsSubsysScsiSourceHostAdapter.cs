using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceHostAdapter")]
    public class DomainDevicesHostdevsSubsysScsiSourceHostAdapter : libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceHostAdapter
    {
        /// <summary>Sets the name of the host SCSI adapter (for example a HBA or SCSI host name) from which the device is sourced;</summary>
        /// <remarks>
        /// this attribute is required when using the adapter-based SCSI source.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
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
