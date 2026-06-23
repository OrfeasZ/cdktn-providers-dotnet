using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsMidoNet")]
    public class DomainDevicesInterfacesVirtualPortParamsMidoNet : libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsMidoNet
    {
        /// <summary>Sets the Midonet virtual interface identifier associated with this NIC;</summary>
        /// <remarks>
        /// the value is user-provided and must match the interface ID configured in Midonet.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interface_id Domain#interface_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InterfaceId
        {
            get;
            set;
        }
    }
}
