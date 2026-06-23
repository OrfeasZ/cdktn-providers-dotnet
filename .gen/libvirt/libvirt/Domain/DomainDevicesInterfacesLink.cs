using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesLink")]
    public class DomainDevicesInterfacesLink : libvirt.Domain.IDomainDevicesInterfacesLink
    {
        /// <summary>Sets the virtual link state for the NIC, with valid values "up" or "down" (when "down", the interface behaves as if unplugged in the guest).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#modifying-virtual-link-state">https://libvirt.org/formatdomain.html#modifying-virtual-link-state</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#state Domain#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public string State
        {
            get;
            set;
        }
    }
}
