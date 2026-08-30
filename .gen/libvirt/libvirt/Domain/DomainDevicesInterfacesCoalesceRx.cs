using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesCoalesceRx")]
    public class DomainDevicesInterfacesCoalesceRx : libvirt.Domain.IDomainDevicesInterfacesCoalesceRx
    {
        /// <summary>Configures coalescing based on the number of received frames before an interrupt or notification is generated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#frames Domain#frames}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "frames", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesceRxFrames\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesCoalesceRxFrames? Frames
        {
            get;
            set;
        }
    }
}
