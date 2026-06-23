using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInputsSource")]
    public class DomainDevicesInputsSource : libvirt.Domain.IDomainDevicesInputsSource
    {
        /// <summary>Attaches the input device to a host evdev device node, allowing direct passthrough of events from that device to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ev_dev Domain#ev_dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "evDev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsSourceEvDev\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInputsSourceEvDev? EvDev
        {
            get;
            set;
        }

        /// <summary>Configures the input device as a passthrough device using a host evdev path, allowing low-level event forwarding directly to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#passthrough Domain#passthrough}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInputsSourcePassthrough\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInputsSourcePassthrough? Passthrough
        {
            get;
            set;
        }
    }
}
