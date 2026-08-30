using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksTarget")]
    public class DomainDevicesDisksTarget : libvirt.Domain.IDomainDevicesDisksTarget
    {
        /// <summary>Sets the guest bus type this disk is attached to, such as "ide", "sata", "scsi", "virtio", "usb", or "xen".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bus Domain#bus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bus
        {
            get;
            set;
        }

        /// <summary>Sets the guest device name exposed by this disk on the chosen bus (for example "vda", "sda", or "hda").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dev
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dpofua Domain#dpofua}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dpofua", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dpofua
        {
            get;
            set;
        }

        /// <summary>Sets whether the guest can treat this disk as removable media;</summary>
        /// <remarks>
        /// accepts "on" or "off" when supported by the bus/model.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#removable Domain#removable}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "removable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Removable
        {
            get;
            set;
        }

        /// <summary>Sets the simulated disk rotation rate in revolutions per minute (RPM), typically "1" for SSDs or a realistic integer like "7200" for HDDs.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#rotation_rate Domain#rotation_rate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rotationRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RotationRate
        {
            get;
            set;
        }

        /// <summary>Sets the current tray state for tray-capable devices (e.g. CD-ROM), accepting "open" or "closed".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tray Domain#tray}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tray", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tray
        {
            get;
            set;
        }
    }
}
