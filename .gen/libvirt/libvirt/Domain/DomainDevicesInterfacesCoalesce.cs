using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesCoalesce")]
    public class DomainDevicesInterfacesCoalesce : libvirt.Domain.IDomainDevicesInterfacesCoalesce
    {
        /// <summary>Configures receive‑side coalescing parameters for this interface.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#rx Domain#rx}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rx", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesceRx\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesCoalesceRx? Rx
        {
            get;
            set;
        }
    }
}
