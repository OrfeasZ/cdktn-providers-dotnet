using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceInternal")]
    public class DomainDevicesInterfacesSourceInternal : libvirt.Domain.IDomainDevicesInterfacesSourceInternal
    {
        /// <summary>Sets the name of the internal network that the interface connects to;</summary>
        /// <remarks>
        /// value is user-provided and must match the identifier used by the underlying hypervisor for that internal network.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
