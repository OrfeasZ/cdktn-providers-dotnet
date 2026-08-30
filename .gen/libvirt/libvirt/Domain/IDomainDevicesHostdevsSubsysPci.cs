using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysPci), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysPci")]
    public interface IDomainDevicesHostdevsSubsysPci
    {
        /// <summary>Controls whether this PCI hostdev is treated as a display device (for example, a GPU providing primary display);</summary>
        /// <remarks>
        /// valid values are "on" or "off" as yes/no flags when supported.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#display Domain#display}
        /// </remarks>
        [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Display
        {
            get
            {
                return null;
            }
        }

        /// <summary>Groups driver-related configuration for PCI passthrough, such as which kernel driver or model to use for the device in the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysPciDriver? Driver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether a ramfb (in-memory frame buffer) is created for this PCI hostdev, typically used with GPUs;</summary>
        /// <remarks>
        /// accepts "on"/"off" as yes/no flags when supported.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ram_fb Domain#ram_fb}
        /// </remarks>
        [JsiiProperty(name: "ramFb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RamFb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Groups the source configuration for the PCI device being passed through, including its PCI address on the host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysPciSource? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures this PCI hostdev as part of an interface teaming/bonding setup in the guest, pairing it with another interface for failover.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#teaming Domain#teaming}
        /// </remarks>
        [JsiiProperty(name: "teaming", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciTeaming\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysPciTeaming? Teaming
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysPci), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysPci")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysPci
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether this PCI hostdev is treated as a display device (for example, a GPU providing primary display);</summary>
            /// <remarks>
            /// valid values are "on" or "off" as yes/no flags when supported.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#display Domain#display}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Display
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Groups driver-related configuration for PCI passthrough, such as which kernel driver or model to use for the device in the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciDriver\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysPciDriver? Driver
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysPciDriver?>();
            }

            /// <summary>Controls whether a ramfb (in-memory frame buffer) is created for this PCI hostdev, typically used with GPUs;</summary>
            /// <remarks>
            /// accepts "on"/"off" as yes/no flags when supported.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ram_fb Domain#ram_fb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ramFb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RamFb
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Groups the source configuration for the PCI device being passed through, including its PCI address on the host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysPciSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysPciSource?>();
            }

            /// <summary>Configures this PCI hostdev as part of an interface teaming/bonding setup in the guest, pairing it with another interface for failover.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#teaming Domain#teaming}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "teaming", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciTeaming\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysPciTeaming? Teaming
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysPciTeaming?>();
            }
        }
    }
}
