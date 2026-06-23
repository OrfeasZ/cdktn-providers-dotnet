using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysMDev), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysMDev")]
    public interface IDomainDevicesHostdevsSubsysMDev
    {
        /// <summary>Sets how display output of a mediated (mdev) device is exposed to the guest;</summary>
        /// <remarks>
        /// the value is user-provided and backend-specific (for example, selecting a particular vGPU display mode).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#display Domain#display}
        /// </remarks>
        [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Display
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the mediated device (mdev) model for this hostdev, identifying which virtual function or vGPU type is exposed to the guest;</summary>
        /// <remarks>
        /// the value is user-provided and must match a model supported by the host driver (for example, an NVIDIA vGPU type name).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether a frame buffer (ramfb) is created for this mediated device;</summary>
        /// <remarks>
        /// accepts "on"/"off" as yes/no flags when supported by the host driver.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ram_fb Domain#ram_fb}
        /// </remarks>
        [JsiiProperty(name: "ramFb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RamFb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Groups the source configuration for the mediated device passed through to the guest, such as its unique address on the host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysMDevSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysMDev), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysMDev")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysMDev
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets how display output of a mediated (mdev) device is exposed to the guest;</summary>
            /// <remarks>
            /// the value is user-provided and backend-specific (for example, selecting a particular vGPU display mode).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#display Domain#display}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Display
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the mediated device (mdev) model for this hostdev, identifying which virtual function or vGPU type is exposed to the guest;</summary>
            /// <remarks>
            /// the value is user-provided and must match a model supported by the host driver (for example, an NVIDIA vGPU type name).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Model
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether a frame buffer (ramfb) is created for this mediated device;</summary>
            /// <remarks>
            /// accepts "on"/"off" as yes/no flags when supported by the host driver.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ram_fb Domain#ram_fb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ramFb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RamFb
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Groups the source configuration for the mediated device passed through to the guest, such as its unique address on the host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysMDevSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSource?>();
            }
        }
    }
}
