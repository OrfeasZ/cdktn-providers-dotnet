using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesControllersPciModel")]
    public class DomainDevicesControllersPciModel : libvirt.Domain.IDomainDevicesControllersPciModel
    {
        /// <summary>Sets the model name of the PCI controller;</summary>
        /// <remarks>
        /// must be one of the controller models supported by the chosen machine type (for example, "pci-root", "pcie-root-port", "pci-bridge").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
