using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesCoalesceRxFrames")]
    public class DomainDevicesInterfacesCoalesceRxFrames : libvirt.Domain.IDomainDevicesInterfacesCoalesceRxFrames
    {
        /// <summary>Sets the maximum number of received frames that may be coalesced before triggering processing;</summary>
        /// <remarks>
        /// value is a non‑negative integer in frames.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#coalesce-settings">https://libvirt.org/formatdomain.html#coalesce-settings</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max Domain#max}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Max
        {
            get;
            set;
        }
    }
}
