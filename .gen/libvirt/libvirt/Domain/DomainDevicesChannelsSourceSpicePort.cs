using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesChannelsSourceSpicePort")]
    public class DomainDevicesChannelsSourceSpicePort : libvirt.Domain.IDomainDevicesChannelsSourceSpicePort
    {
        /// <summary>Sets the SPICE channel name used by the EGD RNG backend when the entropy source is a SPICE port;</summary>
        /// <remarks>
        /// the value is user-provided (for example, a named SPICE channel).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#channel Domain#channel}
        /// </remarks>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        public string Channel
        {
            get;
            set;
        }
    }
}
