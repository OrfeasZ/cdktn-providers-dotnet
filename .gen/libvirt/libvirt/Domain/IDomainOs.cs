using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOs), fullyQualifiedName: "libvirt.domain.DomainOs")]
    public interface IDomainOs
    {
        /// <summary>Enables configuration of additional ACPI tables presented to the guest firmware/OS via nested table definitions.</summary>
        /// <remarks>
        /// The element itself has no attributes; behavior is controlled by its child tables.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsAcpi? Acpi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures BIOS-related boot behavior for fully virtualized guests, such as reboot timeout and use of serial console for BIOS messages.</summary>
        /// <remarks>
        /// All child attributes are optional.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bios Domain#bios}
        /// </remarks>
        [JsiiProperty(name: "bios", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsBios\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsBios? Bios
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies an ordered list of devices the firmware should try when booting the guest OS.</summary>
        /// <remarks>
        /// Multiple entries are allowed to define a boot priority list.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#boot_devices Domain#boot_devices}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsBootDevices" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "bootDevices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsBootDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BootDevices
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or configures the firmware boot menu shown before booting the OS, including optional timeout.</summary>
        /// <remarks>
        /// Presence alone does not enable it; see enable/timeout attributes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#boot_menu Domain#boot_menu}
        /// </remarks>
        [JsiiProperty(name: "bootMenu", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsBootMenu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsBootMenu? BootMenu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides the kernel command line arguments passed to the guest when using direct kernel boot;</summary>
        /// <remarks>
        /// the value is a free-form string. Example: "console=ttyS0 root=/dev/vda1".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-kernel-boot">https://libvirt.org/formatdomain.html#direct-kernel-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cmdline Domain#cmdline}
        /// </remarks>
        [JsiiProperty(name: "cmdline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cmdline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the host path to a Device Tree Blob passed to the guest kernel during direct kernel boot on architectures that use DTBs;</summary>
        /// <remarks>
        /// the value is user-provided. Example: "/var/lib/libvirt/images/guest.dtb".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-kernel-boot">https://libvirt.org/formatdomain.html#direct-kernel-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dtb Domain#dtb}
        /// </remarks>
        [JsiiProperty(name: "dtb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dtb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the guest firmware type or boot mode via a string value (for example "efi", "bios", or other driver-dependent identifiers);</summary>
        /// <remarks>
        /// the value is user-provided and must be supported by the hypervisor/host. If unset, the default firmware is used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#firmware Domain#firmware}
        /// </remarks>
        [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Firmware
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides structured configuration for the firmware image when using pflash/NVRAM or other non-default firmware setups, such as specifying a particular firmware file and NVRAM store;</summary>
        /// <remarks>
        /// contents and attributes are user-provided and driver-specific. Use this when finer-grained firmware selection is needed beyond the simple firmware attribute.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#firmware_info Domain#firmware_info}
        /// </remarks>
        [JsiiProperty(name: "firmwareInfo", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsFirmwareInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsFirmwareInfo? FirmwareInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the path to the init binary inside a container-based guest, used instead of a kernel or boot image when booting container domains.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init Domain#init}
        /// </remarks>
        [JsiiProperty(name: "init", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Init
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides additional command-line arguments to pass to the init binary configured by domain.os.init; multiple values map to multiple arguments in order (for example ["--foreground","--config=/cfg"]).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init_args Domain#init_args}
        /// </remarks>
        [JsiiProperty(name: "initArgs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InitArgs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the working directory from which the container init binary is started.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init_dir Domain#init_dir}
        /// </remarks>
        [JsiiProperty(name: "initDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InitDir
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one environment variable to export for the container init process;</summary>
        /// <remarks>
        /// multiple blocks can be used to define multiple variables.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init_env Domain#init_env}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsInitEnv" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "initEnv", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsInitEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InitEnv
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the numeric group ID or group name that the container init process runs as.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init_group Domain#init_group}
        /// </remarks>
        [JsiiProperty(name: "initGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InitGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the path on the host to an initrd image used when directly booting a kernel for the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-kernel-boot">https://libvirt.org/formatdomain.html#direct-kernel-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#initrd Domain#initrd}
        /// </remarks>
        [JsiiProperty(name: "initrd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Initrd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the numeric user ID or user name that the container init process runs as.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init_user Domain#init_user}
        /// </remarks>
        [JsiiProperty(name: "initUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InitUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the path on the host to a kernel image used for direct kernel boot of the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-kernel-boot">https://libvirt.org/formatdomain.html#direct-kernel-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#kernel Domain#kernel}
        /// </remarks>
        [JsiiProperty(name: "kernel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kernel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the path or identifier of the firmware/BIOS/EFI loader image used to boot the guest (for example an OVMF or BIOS binary).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader Domain#loader}
        /// </remarks>
        [JsiiProperty(name: "loader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Loader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the loader image format (for example "raw" or "qcow2") corresponding to the loader;</summary>
        /// <remarks>
        /// value is user-provided but must be supported by the hypervisor/firmware.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader_format Domain#loader_format}
        /// </remarks>
        [JsiiProperty(name: "loaderFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoaderFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the firmware loader image is opened read-only, typically using a "yes"/"no" style flag as expected by libvirt/QEMU.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader_readonly Domain#loader_readonly}
        /// </remarks>
        [JsiiProperty(name: "loaderReadonly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoaderReadonly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables secure boot support for the configured firmware loader, usually via a "yes"/"no" style flag.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader_secure Domain#loader_secure}
        /// </remarks>
        [JsiiProperty(name: "loaderSecure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoaderSecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the firmware loader operates in stateless mode (firmware state not persisted), typically configured as a "yes"/"no" style flag.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader_stateless Domain#loader_stateless}
        /// </remarks>
        [JsiiProperty(name: "loaderStateless", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoaderStateless
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the loader type, such as "pflash" for UEFI flash-based firmware or "rom" for traditional BIOS, with supported values depending on the hypervisor/architecture.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader_type Domain#loader_type}
        /// </remarks>
        [JsiiProperty(name: "loaderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoaderType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the path for the guest NVRAM/UEFI variable store file associated with the firmware loader, allowing persistence of firmware settings across reboots.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nv_ram Domain#nv_ram}
        /// </remarks>
        [JsiiProperty(name: "nvRam", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRam\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRam? NvRam
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides the path to a UEFI shim binary used in secure-boot chains, typically sitting between firmware and the OS loader;</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-kernel-boot">https://libvirt.org/formatdomain.html#direct-kernel-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#shim Domain#shim}
        /// </remarks>
        [JsiiProperty(name: "shim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Shim
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of SMBIOS-related behavior for the guest firmware, such as whether to use host, guest-defined, or sysinfo-based SMBIOS data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sm_bios Domain#sm_bios}
        /// </remarks>
        [JsiiProperty(name: "smBios", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsSmBios\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsSmBios? SmBios
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the guest OS type string (for example, hvm or exe), indicating the virtualization style or booting method expected by the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the architecture for the guest OS type (for example, x86_64 or i686) via the arch attribute, influencing the machine type, CPU model, and firmware choice.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type_arch Domain#type_arch}
        /// </remarks>
        [JsiiProperty(name: "typeArch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TypeArch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the machine type for the guest OS type (for example, pc-q35-2.10 or pc-i440fx-7.2), selecting the chipset and board model used by the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type_machine Domain#type_machine}
        /// </remarks>
        [JsiiProperty(name: "typeMachine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TypeMachine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#var_store Domain#var_store}.</summary>
        [JsiiProperty(name: "varStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsVarStore\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsVarStore? VarStore
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOs), fullyQualifiedName: "libvirt.domain.DomainOs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables configuration of additional ACPI tables presented to the guest firmware/OS via nested table definitions.</summary>
            /// <remarks>
            /// The element itself has no attributes; behavior is controlled by its child tables.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsAcpi?>();
            }

            /// <summary>Configures BIOS-related boot behavior for fully virtualized guests, such as reboot timeout and use of serial console for BIOS messages.</summary>
            /// <remarks>
            /// All child attributes are optional.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bios Domain#bios}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bios", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsBios\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsBios? Bios
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsBios?>();
            }

            /// <summary>Specifies an ordered list of devices the firmware should try when booting the guest OS.</summary>
            /// <remarks>
            /// Multiple entries are allowed to define a boot priority list.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#boot_devices Domain#boot_devices}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsBootDevices" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bootDevices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsBootDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BootDevices
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enables or configures the firmware boot menu shown before booting the OS, including optional timeout.</summary>
            /// <remarks>
            /// Presence alone does not enable it; see enable/timeout attributes.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#boot_menu Domain#boot_menu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bootMenu", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsBootMenu\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsBootMenu? BootMenu
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsBootMenu?>();
            }

            /// <summary>Provides the kernel command line arguments passed to the guest when using direct kernel boot;</summary>
            /// <remarks>
            /// the value is a free-form string. Example: "console=ttyS0 root=/dev/vda1".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-kernel-boot">https://libvirt.org/formatdomain.html#direct-kernel-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cmdline Domain#cmdline}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cmdline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cmdline
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the host path to a Device Tree Blob passed to the guest kernel during direct kernel boot on architectures that use DTBs;</summary>
            /// <remarks>
            /// the value is user-provided. Example: "/var/lib/libvirt/images/guest.dtb".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-kernel-boot">https://libvirt.org/formatdomain.html#direct-kernel-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dtb Domain#dtb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dtb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dtb
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selects the guest firmware type or boot mode via a string value (for example "efi", "bios", or other driver-dependent identifiers);</summary>
            /// <remarks>
            /// the value is user-provided and must be supported by the hypervisor/host. If unset, the default firmware is used.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#firmware Domain#firmware}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Firmware
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provides structured configuration for the firmware image when using pflash/NVRAM or other non-default firmware setups, such as specifying a particular firmware file and NVRAM store;</summary>
            /// <remarks>
            /// contents and attributes are user-provided and driver-specific. Use this when finer-grained firmware selection is needed beyond the simple firmware attribute.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#firmware_info Domain#firmware_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firmwareInfo", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsFirmwareInfo\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsFirmwareInfo? FirmwareInfo
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsFirmwareInfo?>();
            }

            /// <summary>Sets the path to the init binary inside a container-based guest, used instead of a kernel or boot image when booting container domains.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init Domain#init}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "init", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Init
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provides additional command-line arguments to pass to the init binary configured by domain.os.init; multiple values map to multiple arguments in order (for example ["--foreground","--config=/cfg"]).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init_args Domain#init_args}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initArgs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InitArgs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Sets the working directory from which the container init binary is started.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init_dir Domain#init_dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InitDir
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines one environment variable to export for the container init process;</summary>
            /// <remarks>
            /// multiple blocks can be used to define multiple variables.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init_env Domain#init_env}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsInitEnv" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initEnv", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsInitEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InitEnv
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the numeric group ID or group name that the container init process runs as.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init_group Domain#init_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InitGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the path on the host to an initrd image used when directly booting a kernel for the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-kernel-boot">https://libvirt.org/formatdomain.html#direct-kernel-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#initrd Domain#initrd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initrd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Initrd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the numeric user ID or user name that the container init process runs as.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#init_user Domain#init_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InitUser
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the path on the host to a kernel image used for direct kernel boot of the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-kernel-boot">https://libvirt.org/formatdomain.html#direct-kernel-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#kernel Domain#kernel}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kernel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kernel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the path or identifier of the firmware/BIOS/EFI loader image used to boot the guest (for example an OVMF or BIOS binary).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader Domain#loader}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Loader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the loader image format (for example "raw" or "qcow2") corresponding to the loader;</summary>
            /// <remarks>
            /// value is user-provided but must be supported by the hypervisor/firmware.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader_format Domain#loader_format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loaderFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoaderFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the firmware loader image is opened read-only, typically using a "yes"/"no" style flag as expected by libvirt/QEMU.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader_readonly Domain#loader_readonly}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loaderReadonly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoaderReadonly
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables or disables secure boot support for the configured firmware loader, usually via a "yes"/"no" style flag.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader_secure Domain#loader_secure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loaderSecure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoaderSecure
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the firmware loader operates in stateless mode (firmware state not persisted), typically configured as a "yes"/"no" style flag.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader_stateless Domain#loader_stateless}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loaderStateless", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoaderStateless
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the loader type, such as "pflash" for UEFI flash-based firmware or "rom" for traditional BIOS, with supported values depending on the hypervisor/architecture.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#loader_type Domain#loader_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loaderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoaderType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the path for the guest NVRAM/UEFI variable store file associated with the firmware loader, allowing persistence of firmware settings across reboots.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nv_ram Domain#nv_ram}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nvRam", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRam\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRam? NvRam
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRam?>();
            }

            /// <summary>Provides the path to a UEFI shim binary used in secure-boot chains, typically sitting between firmware and the OS loader;</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-kernel-boot">https://libvirt.org/formatdomain.html#direct-kernel-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#shim Domain#shim}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Shim
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables configuration of SMBIOS-related behavior for the guest firmware, such as whether to use host, guest-defined, or sysinfo-based SMBIOS data.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sm_bios Domain#sm_bios}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smBios", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsSmBios\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsSmBios? SmBios
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsSmBios?>();
            }

            /// <summary>Sets the guest OS type string (for example, hvm or exe), indicating the virtualization style or booting method expected by the hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the architecture for the guest OS type (for example, x86_64 or i686) via the arch attribute, influencing the machine type, CPU model, and firmware choice.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type_arch Domain#type_arch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "typeArch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TypeArch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the machine type for the guest OS type (for example, pc-q35-2.10 or pc-i440fx-7.2), selecting the chipset and board model used by the hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type_machine Domain#type_machine}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "typeMachine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TypeMachine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#var_store Domain#var_store}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "varStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsVarStore\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsVarStore? VarStore
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsVarStore?>();
            }
        }
    }
}
