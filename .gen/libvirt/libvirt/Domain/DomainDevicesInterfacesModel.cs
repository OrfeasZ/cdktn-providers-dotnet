using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesModel")]
    public class DomainDevicesInterfacesModel : libvirt.Domain.IDomainDevicesInterfacesModel
    {
        /// <summary>Sets the NIC model name to present to the guest;</summary>
        /// <remarks>
        /// valid values are user-provided model identifiers such as "virtio", "e1000", "rtl8139", etc.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-the-nic-model">https://libvirt.org/formatdomain.html#setting-the-nic-model</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
