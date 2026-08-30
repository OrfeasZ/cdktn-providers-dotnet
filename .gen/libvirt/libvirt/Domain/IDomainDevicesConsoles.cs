using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesConsoles), fullyQualifiedName: "libvirt.domain.DomainDevicesConsoles")]
    public interface IDomainDevicesConsoles
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesConsolesAcpi? Acpi
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
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesConsolesAddress? Address
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
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesConsolesAlias? Alias
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
        [JsiiProperty(name: "log", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesConsolesLog? Log
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
        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesProtocol\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesConsolesProtocol? Protocol
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
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesConsolesSource? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures how the console appears inside the guest (e.g. which guest console/serial port it is attached to).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesConsolesTarget? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>Records or overrides the host-side TTY or device path associated with this console (for example "/dev/pts/3"); value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pseudo-tty">https://libvirt.org/formatdomain.html#pseudo-tty</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tty Domain#tty}
        /// </remarks>
        [JsiiProperty(name: "tty", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tty
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesConsoles), fullyQualifiedName: "libvirt.domain.DomainDevicesConsoles")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesConsoles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesConsolesAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesConsolesAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesConsolesAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesConsolesAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesConsolesAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesConsolesAlias?>();
            }

            /// <summary>Enables logging of data sent through the channel to a host file and configures how that logging behaves.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#log Domain#log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "log", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesLog\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesConsolesLog? Log
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesConsolesLog?>();
            }

            /// <summary>Configures the transport protocol used by the EGD backend connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#protocol Domain#protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesProtocol\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesConsolesProtocol? Protocol
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesConsolesProtocol?>();
            }

            /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesConsolesSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesConsolesSource?>();
            }

            /// <summary>Configures how the console appears inside the guest (e.g. which guest console/serial port it is attached to).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesConsolesTarget\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesConsolesTarget? Target
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesConsolesTarget?>();
            }

            /// <summary>Records or overrides the host-side TTY or device path associated with this console (for example "/dev/pts/3"); value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#pseudo-tty">https://libvirt.org/formatdomain.html#pseudo-tty</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tty Domain#tty}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tty", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tty
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
