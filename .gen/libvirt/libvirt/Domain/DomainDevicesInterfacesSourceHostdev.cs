using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceHostdev")]
    public class DomainDevicesInterfacesSourceHostdev : libvirt.Domain.IDomainDevicesInterfacesSourceHostdev
    {
        /// <summary>Groups the source configuration for the PCI device being passed through, including its PCI address on the host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pci Domain#pci}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pci", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevPci\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPci? Pci
        {
            get;
            set;
        }

        /// <summary>Sets how the USB host device is identified for passthrough, either by topology (bus/port) or by vendor/product IDs and related options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#usb Domain#usb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usb", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsb\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsb? Usb
        {
            get;
            set;
        }
    }
}
