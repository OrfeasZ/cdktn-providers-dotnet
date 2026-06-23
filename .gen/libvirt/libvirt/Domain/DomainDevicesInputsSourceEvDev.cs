using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInputsSourceEvDev")]
    public class DomainDevicesInputsSourceEvDev : libvirt.Domain.IDomainDevicesInputsSourceEvDev
    {
        /// <summary>Specifies the mandatory path to the host evdev device node (for example, "/dev/input/event3") that backs this input device.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        public string Dev
        {
            get;
            set;
        }

        /// <summary>Controls whether libvirt/QEMU grabs exclusive access to the host evdev device ("yes" or "no"), preventing it from being used by the host while attached to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#grab Domain#grab}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grab", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Grab
        {
            get;
            set;
        }

        /// <summary>Enables or disables hotkey-based toggling of the grab state for the evdev device, typically using "yes" or "no" if supported.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#grab_toggle Domain#grab_toggle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grabToggle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GrabToggle
        {
            get;
            set;
        }

        /// <summary>Controls whether key repeat is handled for this evdev-based input device ("yes" or "no"), affecting how held keys generate repeated events in the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#repeat Domain#repeat}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repeat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Repeat
        {
            get;
            set;
        }
    }
}
