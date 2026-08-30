using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesSerials), fullyQualifiedName: "libvirt.domain.DomainDevicesSerials")]
    public interface IDomainDevicesSerials
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSerialsAcpi? Acpi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSerialsAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSerialsAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables logging of data sent through the channel to a host file and configures how that logging behaves.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#log Domain#log}
        /// </remarks>
        [JsiiProperty(name: "log", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSerialsLog? Log
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the transport protocol used by the EGD backend connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#protocol Domain#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsProtocol\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSerialsProtocol? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSerialsSource? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the guest-visible target of the serial device, such as the port number and, where applicable, the subtype (for example, "isa-serial" port 0).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesSerialsTarget? Target
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesSerials), fullyQualifiedName: "libvirt.domain.DomainDevicesSerials")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesSerials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSerialsAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSerialsAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSerialsAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSerialsAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSerialsAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSerialsAlias?>();
            }

            /// <summary>Enables logging of data sent through the channel to a host file and configures how that logging behaves.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#log Domain#log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "log", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsLog\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSerialsLog? Log
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSerialsLog?>();
            }

            /// <summary>Configures the transport protocol used by the EGD backend connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#protocol Domain#protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsProtocol\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSerialsProtocol? Protocol
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSerialsProtocol?>();
            }

            /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSerialsSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSerialsSource?>();
            }

            /// <summary>Configures the guest-visible target of the serial device, such as the port number and, where applicable, the subtype (for example, "isa-serial" port 0).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsTarget\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesSerialsTarget? Target
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesSerialsTarget?>();
            }
        }
    }
}
