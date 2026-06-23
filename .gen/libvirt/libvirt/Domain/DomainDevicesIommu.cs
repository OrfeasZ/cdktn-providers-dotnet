using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesIommu")]
    public class DomainDevicesIommu : libvirt.Domain.IDomainDevicesIommu
    {
        /// <summary>Selects the IOMMU model to expose to the guest;</summary>
        /// <remarks>
        /// valid values include "intel", "smmuv3", and "virtio" depending on architecture and QEMU version.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        public string Model
        {
            get;
            set;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommuAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesIommuAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommuAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesIommuAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommuAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesIommuAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Configures model-specific driver options for the IOMMU, such as address width, interrupt remapping, and caching behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommuDriver\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesIommuDriver? Driver
        {
            get;
            set;
        }
    }
}
