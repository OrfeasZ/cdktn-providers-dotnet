using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesRngs")]
    public class DomainDevicesRngs : libvirt.Domain.IDomainDevicesRngs
    {
        /// <summary>Sets the RNG device model, for example "virtio" for a paravirtual RNG;</summary>
        /// <remarks>
        /// the value is required and must be a model supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
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
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRngsAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRngsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRngsAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Configures the entropy backend that the RNG device uses, such as a built-in source or an external EGD-compatible source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#backend Domain#backend}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsBackend\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRngsBackend? Backend
        {
            get;
            set;
        }

        /// <summary>Configures virtio transport–specific driver options for the RNG device, such as IOMMU and ATS behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsDriver\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRngsDriver? Driver
        {
            get;
            set;
        }

        /// <summary>Configures optional rate limiting for the RNG device, constraining how much entropy is delivered to the guest over time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rate Domain#rate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rate", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsRate\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesRngsRate? Rate
        {
            get;
            set;
        }
    }
}
