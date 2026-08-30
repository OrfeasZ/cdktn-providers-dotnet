using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsSpiceListeners")]
    public class DomainDevicesGraphicsSpiceListeners : libvirt.Domain.IDomainDevicesGraphicsSpiceListeners
    {
        /// <summary>Declares a SPICE listener that binds directly to a host IP address using the nested `address` attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListenersAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceListenersAddress? Address
        {
            get;
            set;
        }

        /// <summary>Declares a SPICE listener whose binding is determined by the specified libvirt virtual network and optional address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#network Domain#network}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListenersNetwork\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceListenersNetwork? Network
        {
            get;
            set;
        }

        /// <summary>Declares a SPICE listener that uses a UNIX domain socket instead of TCP/IP for client connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#socket Domain#socket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "socket", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListenersSocket\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceListenersSocket? Socket
        {
            get;
            set;
        }
    }
}
