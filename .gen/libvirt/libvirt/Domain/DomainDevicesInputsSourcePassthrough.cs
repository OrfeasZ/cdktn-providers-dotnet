using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInputsSourcePassthrough")]
    public class DomainDevicesInputsSourcePassthrough : libvirt.Domain.IDomainDevicesInputsSourcePassthrough
    {
        /// <summary>Specifies the mandatory path to the host evdev device node used for passthrough (for example, "/dev/input/event5");</summary>
        /// <remarks>
        /// the value is a user-provided absolute device path.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ev_dev Domain#ev_dev}
        /// </remarks>
        [JsiiProperty(name: "evDev", typeJson: "{\"primitive\":\"string\"}")]
        public string EvDev
        {
            get;
            set;
        }
    }
}
