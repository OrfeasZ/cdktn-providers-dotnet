using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesControllersPci")]
    public class DomainDevicesControllersPci : libvirt.Domain.IDomainDevicesControllersPci
    {
        /// <summary>Sets the size of the 64‑bit PCI memory hole available to guest PCI devices;</summary>
        /// <remarks>
        /// value is user-provided and interpreted together with hole64_unit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hole64 Domain#hole64}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hole64", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hole64
        {
            get;
            set;
        }

        /// <summary>Specifies the unit for the pci.hole64 size (for example, "KiB", "MiB", "GiB"), paired with the hole64 value to define the 64‑bit PCI memory hole size.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hole64_unit Domain#hole64_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hole64Unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hole64Unit
        {
            get;
            set;
        }

        /// <summary>Configures the PCI/PCIe controller model, determining the controller implementation used by the guest (for example, "pci-root" or "pcie-root-port").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersPciModel\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersPciModel? Model
        {
            get;
            set;
        }

        /// <summary>Configures additional PCI controller target parameters such as bus or port indices that control how the controller is placed in the guest topology;</summary>
        /// <remarks>
        /// values are user-provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersPciTarget\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersPciTarget? Target
        {
            get;
            set;
        }
    }
}
