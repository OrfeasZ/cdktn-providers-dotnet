using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesCrypto")]
    public class DomainDevicesCrypto : libvirt.Domain.IDomainDevicesCrypto
    {
        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesCryptoAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesCryptoAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesCryptoAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesCryptoAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Configures the backend implementation details for the crypto device, such as whether it is built-in or uses the LKCF kernel framework.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backend Domain#backend}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesCryptoBackend\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesCryptoBackend? Backend
        {
            get;
            set;
        }

        /// <summary>Selects the crypto device model;</summary>
        /// <remarks>
        /// for recent libvirt/QEMU this must be a virtio variant such as "virtio", "virtio-transitional", or "virtio-non-transitional".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Model
        {
            get;
            set;
        }

        /// <summary>Selects the crypto device type/implementation, which currently supports "qemu";</summary>
        /// <remarks>
        /// the value is user-provided but must be supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
