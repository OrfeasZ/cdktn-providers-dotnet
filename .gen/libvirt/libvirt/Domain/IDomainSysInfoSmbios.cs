using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainSysInfoSmbios), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbios")]
    public interface IDomainSysInfoSmbios
    {
        /// <summary>Configures the SMBIOS base board (motherboard) section, allowing customization of board-level fields presented to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#base_board Domain#base_board}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosBaseBoard" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "baseBoard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBaseBoard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BaseBoard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the SMBIOS BIOS information block, enabling you to override individual BIOS-related fields exposed to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bios Domain#bios}
        /// </remarks>
        [JsiiProperty(name: "bios", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBios\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainSysInfoSmbiosBios? Bios
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the SMBIOS chassis information block, allowing overrides for how the guest sees chassis-related system information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#chassis Domain#chassis}
        /// </remarks>
        [JsiiProperty(name: "chassis", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosChassis\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainSysInfoSmbiosChassis? Chassis
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the SMBIOS memory information block, allowing customized memory-related fields to be exposed to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory Domain#memory}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosMemory" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "memory", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosMemory\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Memory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the SMBIOS OEM strings block, allowing arbitrary vendor-specific strings to be presented to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#oem_strings Domain#oem_strings}
        /// </remarks>
        [JsiiProperty(name: "oemStrings", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosOemStrings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainSysInfoSmbiosOemStrings? OemStrings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the SMBIOS processor information block, enabling overrides of CPU-related identification fields.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#processor Domain#processor}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosProcessor" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "processor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosProcessor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Processor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of custom SMBIOS “system” table fields presented to the guest, such as product name, version, serial, and UUID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#system Domain#system}
        /// </remarks>
        [JsiiProperty(name: "systemAttribute", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosSystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainSysInfoSmbiosSystem? SystemAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainSysInfoSmbios), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbios")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainSysInfoSmbios
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the SMBIOS base board (motherboard) section, allowing customization of board-level fields presented to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#base_board Domain#base_board}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosBaseBoard" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baseBoard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBaseBoard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BaseBoard
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures the SMBIOS BIOS information block, enabling you to override individual BIOS-related fields exposed to the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bios Domain#bios}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bios", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBios\"}", isOptional: true)]
            public libvirt.Domain.IDomainSysInfoSmbiosBios? Bios
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainSysInfoSmbiosBios?>();
            }

            /// <summary>Configures the SMBIOS chassis information block, allowing overrides for how the guest sees chassis-related system information.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#chassis Domain#chassis}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "chassis", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosChassis\"}", isOptional: true)]
            public libvirt.Domain.IDomainSysInfoSmbiosChassis? Chassis
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainSysInfoSmbiosChassis?>();
            }

            /// <summary>Configures the SMBIOS memory information block, allowing customized memory-related fields to be exposed to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory Domain#memory}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosMemory" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memory", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosMemory\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Memory
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures the SMBIOS OEM strings block, allowing arbitrary vendor-specific strings to be presented to the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#oem_strings Domain#oem_strings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oemStrings", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosOemStrings\"}", isOptional: true)]
            public libvirt.Domain.IDomainSysInfoSmbiosOemStrings? OemStrings
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainSysInfoSmbiosOemStrings?>();
            }

            /// <summary>Configures the SMBIOS processor information block, enabling overrides of CPU-related identification fields.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#processor Domain#processor}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosProcessor" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosProcessor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Processor
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enables configuration of custom SMBIOS “system” table fields presented to the guest, such as product name, version, serial, and UUID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#system Domain#system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "systemAttribute", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosSystem\"}", isOptional: true)]
            public libvirt.Domain.IDomainSysInfoSmbiosSystem? SystemAttribute
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainSysInfoSmbiosSystem?>();
            }
        }
    }
}
