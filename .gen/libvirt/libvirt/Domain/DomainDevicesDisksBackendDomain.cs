using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksBackendDomain")]
    public class DomainDevicesDisksBackendDomain : libvirt.Domain.IDomainDevicesDisksBackendDomain
    {
        /// <summary>Sets the name of the backend (driver) domain that will host the network backend for this interface;</summary>
        /// <remarks>
        /// value must match an existing domain name.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-up-a-network-backend-in-a-driver-domain">https://libvirt.org/formatdomain.html#setting-up-a-network-backend-in-a-driver-domain</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
