using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsCapsNetSource")]
    public class DomainDevicesHostdevsCapsNetSource : libvirt.Domain.IDomainDevicesHostdevsCapsNetSource
    {
        /// <summary>Specifies the name of the host network interface used as the source for the passthrough network device (for example, "eth0");</summary>
        /// <remarks>
        /// this field is required when configuring caps_net.source.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#interface Domain#interface}
        /// </remarks>
        [JsiiProperty(name: "interface", typeJson: "{\"primitive\":\"string\"}")]
        public string Interface
        {
            get;
            set;
        }
    }
}
