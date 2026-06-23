using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesVideos")]
    public class DomainDevicesVideos : libvirt.Domain.IDomainDevicesVideos
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesVideosAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesVideosAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesVideosAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Configures low-level driver options for the video device, such as virtio transport and VGA behavior;</summary>
        /// <remarks>
        /// attributes are driver- and model-specific.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosDriver\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesVideosDriver? Driver
        {
            get;
            set;
        }

        /// <summary>Defines the emulated video adapter model (for example `vga`, `cirrus`, `qxl`, `virtio`, `bochs`), which determines capabilities such as resolutions and acceleration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosModel\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesVideosModel? Model
        {
            get;
            set;
        }
    }
}
