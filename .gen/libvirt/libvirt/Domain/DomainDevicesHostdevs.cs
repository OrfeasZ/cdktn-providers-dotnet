using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevs")]
    public class DomainDevicesHostdevs : libvirt.Domain.IDomainDevicesHostdevs
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Enables boot-order control for this redirected device, allowing it to participate in the device boot sequence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#boot Domain#boot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsBoot\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsBoot? Boot
        {
            get;
            set;
        }

        /// <summary>Enables miscellaneous capability-specific configuration for the host device, used for device types that expose extra capabilities not covered by other elements.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#caps_misc Domain#caps_misc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capsMisc", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsMisc\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsCapsMisc? CapsMisc
        {
            get;
            set;
        }

        /// <summary>Enables network-related capability configuration for the host device, typically for host NICs or VF-based network passthrough with extra capabilities.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#caps_net Domain#caps_net}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capsNet", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsNet\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsCapsNet? CapsNet
        {
            get;
            set;
        }

        /// <summary>Configures storage-related capabilities for a passthrough host device, such as its backing block source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#caps_storage Domain#caps_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capsStorage", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsStorage\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsCapsStorage? CapsStorage
        {
            get;
            set;
        }

        private object? _managed;

        /// <summary>Controls whether libvirt manages detaching and reattaching the host device driver, as a string boolean where "yes" enables management and "no" disables it.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#managed Domain#managed}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Managed
        {
            get => _managed;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _managed = value;
            }
        }

        /// <summary>Configures an optional PCI ROM image for the passthrough host device, including whether it is enabled, where it is mapped, and an alternate ROM file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#rom Domain#rom}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rom", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsRom\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsRom? Rom
        {
            get;
            set;
        }

        /// <summary>Configures mediated device (mdev)–specific settings for a passthrough host device, such as display handling for a vGPU.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#subsys_m_dev Domain#subsys_m_dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subsysMDev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysMDev\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysMDev? SubsysMDev
        {
            get;
            set;
        }

        /// <summary>Selects PCI as the host device subsystem type and groups all PCI-specific passthrough settings for this hostdev.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#subsys_pci Domain#subsys_pci}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subsysPci", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPci\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysPci? SubsysPci
        {
            get;
            set;
        }

        /// <summary>Configures a host SCSI device (or LUN) to be passed through to the guest using a SCSI hostdev subsystem.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#subsys_scsi Domain#subsys_scsi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subsysScsi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysScsi? SubsysScsi
        {
            get;
            set;
        }

        /// <summary>Configures a SCSI host adapter–style host device passthrough (SubsysSCSIHost) to the guest, rather than an individual LUN.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#subsys_scsi_host Domain#subsys_scsi_host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subsysScsiHost", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiHost\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiHost? SubsysScsiHost
        {
            get;
            set;
        }

        /// <summary>Configures a host USB device passthrough entry for the guest, corresponding to a `&lt;hostdev&gt;` with USB subsystem-specific settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#subsys_usb Domain#subsys_usb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subsysUsb", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsb\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysUsb? SubsysUsb
        {
            get;
            set;
        }
    }
}
