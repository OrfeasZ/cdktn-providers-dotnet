using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksTarget")]
    public interface IDomainDevicesDisksTarget
    {
        /// <summary>Sets the guest bus type this disk is attached to, such as "ide", "sata", "scsi", "virtio", "usb", or "xen".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bus Domain#bus}
        /// </remarks>
        [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the guest device name exposed by this disk on the chosen bus (for example "vda", "sda", or "hda").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dev
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets whether the guest can treat this disk as removable media;</summary>
        /// <remarks>
        /// accepts "on" or "off" when supported by the bus/model.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#removable Domain#removable}
        /// </remarks>
        [JsiiProperty(name: "removable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Removable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the simulated disk rotation rate in revolutions per minute (RPM), typically "1" for SSDs or a realistic integer like "7200" for HDDs.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rotation_rate Domain#rotation_rate}
        /// </remarks>
        [JsiiProperty(name: "rotationRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RotationRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the current tray state for tray-capable devices (e.g. CD-ROM), accepting "open" or "closed".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tray Domain#tray}
        /// </remarks>
        [JsiiProperty(name: "tray", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tray
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksTarget")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the guest bus type this disk is attached to, such as "ide", "sata", "scsi", "virtio", "usb", or "xen".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bus Domain#bus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the guest device name exposed by this disk on the chosen bus (for example "vda", "sda", or "hda").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dev
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets whether the guest can treat this disk as removable media;</summary>
            /// <remarks>
            /// accepts "on" or "off" when supported by the bus/model.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#removable Domain#removable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "removable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Removable
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the simulated disk rotation rate in revolutions per minute (RPM), typically "1" for SSDs or a realistic integer like "7200" for HDDs.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rotation_rate Domain#rotation_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rotationRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RotationRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the current tray state for tray-capable devices (e.g. CD-ROM), accepting "open" or "closed".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tray Domain#tray}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tray", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tray
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
