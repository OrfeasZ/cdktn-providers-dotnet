using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesRngsBackendEgd")]
    public class DomainDevicesRngsBackendEgd : libvirt.Domain.IDomainDevicesRngsBackendEgd
    {
        /// <summary>Configures the transport protocol used by the EGD backend connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#protocol Domain#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsBackendEgdProtocol\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRngsBackendEgdProtocol? Protocol
        {
            get;
            set;
        }

        /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsBackendEgdSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRngsBackendEgdSource? Source
        {
            get;
            set;
        }
    }
}
