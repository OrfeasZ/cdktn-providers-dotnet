using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeatures), fullyQualifiedName: "libvirt.domain.DomainFeatures")]
    public interface IDomainFeatures
    {
        /// <summary>Controls exposure of ACPI support to the guest;</summary>
        /// <remarks>
        /// presence of this element enables ACPI, while its omission leaves it at libvirt’s default behavior.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Acpi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the Advanced Interrupt Architecture (AIA) feature for the guest CPU/machine, with the specific mode or value being user‑provided according to hypervisor support.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#aia Domain#aia}
        /// </remarks>
        [JsiiProperty(name: "aia", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesAia\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesAia? Aia
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables inclusion of the APIC (Advanced Programmable Interrupt Controller) feature block for the guest;</summary>
        /// <remarks>
        /// presence of this block allows configuring APIC-related behavior such as end-of-interrupt handling.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#apic Domain#apic}
        /// </remarks>
        [JsiiProperty(name: "apic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesApic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesApic? Apic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of asynchronous teardown support for the guest;</summary>
        /// <remarks>
        /// when present, it allows controlling whether the hypervisor uses async teardown semantics.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#async_teardown Domain#async_teardown}
        /// </remarks>
        [JsiiProperty(name: "asyncTeardown", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesAsyncTeardown\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesAsyncTeardown? AsyncTeardown
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures per-domain Linux capability controls, allowing fine-grained enabling or disabling of specific capabilities inside the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#capabilities Domain#capabilities}
        /// </remarks>
        [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilities\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilities? Capabilities
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ccf_assist Domain#ccf_assist}
        /// </remarks>
        [JsiiProperty(name: "ccfAssist", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCcfAssist\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCcfAssist? CcfAssist
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the "cfpc" CPU feature (a speculative-execution/flush-control mitigation) policy for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cfpc Domain#cfpc}
        /// </remarks>
        [JsiiProperty(name: "cfpc", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCfpc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCfpc? Cfpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the ARM Generic Interrupt Controller (GIC) feature for the guest, allowing selection or control of the emulated GIC model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#gic Domain#gic}
        /// </remarks>
        [JsiiProperty(name: "gic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesGic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesGic? Gic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hap Domain#hap}
        /// </remarks>
        [JsiiProperty(name: "hap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHap\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHap? Hap
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the hashed page table (HPT) feature used by some PowerPC guests, including its size and resizing behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hpt Domain#hpt}
        /// </remarks>
        [JsiiProperty(name: "hpt", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHpt\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHpt? Hpt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#htm Domain#htm}
        /// </remarks>
        [JsiiProperty(name: "htm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHtm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHtm? Htm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of Hyper-V enlightenment features for the guest when running on a Hyper-V-capable hypervisor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hyper_v Domain#hyper_v}
        /// </remarks>
        [JsiiProperty(name: "hyperV", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperV\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperV? HyperV
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of the Instruction Based Sampling (IBS) CPU feature on supported AMD guests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ibs Domain#ibs}
        /// </remarks>
        [JsiiProperty(name: "ibs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesIbs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesIbs? Ibs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the emulation mode for the virtual IOAPIC used for interrupt routing in the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ioapic Domain#ioapic}
        /// </remarks>
        [JsiiProperty(name: "ioapic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesIoapic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesIoapic? Ioapic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of KVM-specific CPU or machine features via its child elements (for example, toggling individual KVM feature flags).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#kvm Domain#kvm}
        /// </remarks>
        [JsiiProperty(name: "kvm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesKvm? Kvm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures handling of unknown/unsupported model-specific registers (MSRs) encountered in the guest, controlling whether guest MSR accesses can be ignored or cause failures.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#msrs Domain#msrs}
        /// </remarks>
        [JsiiProperty(name: "msrs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesMsrs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesMsrs? Msrs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nested_hv Domain#nested_hv}
        /// </remarks>
        [JsiiProperty(name: "nestedHv", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesNestedHv\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesNestedHv? NestedHv
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables Physical Address Extension (PAE) support for the guest;</summary>
        /// <remarks>
        /// when set true the PAE feature element is emitted, when false or unset it is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pae Domain#pae}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "pae", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Pae
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pmu Domain#pmu}
        /// </remarks>
        [JsiiProperty(name: "pmu", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPmu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesPmu? Pmu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables the hypervisor’s private networking feature for the guest;</summary>
        /// <remarks>
        /// when set true the privnet feature element is emitted, when false or unset it is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#priv_net Domain#priv_net}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "privNet", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivNet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ps2 Domain#ps2}
        /// </remarks>
        [JsiiProperty(name: "ps2", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPs2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesPs2? Ps2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pv_spinlock Domain#pv_spinlock}
        /// </remarks>
        [JsiiProperty(name: "pvSpinlock", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPvSpinlock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesPvSpinlock? PvSpinlock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ras Domain#ras}
        /// </remarks>
        [JsiiProperty(name: "ras", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesRas\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesRas? Ras
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the Spectre-Boundary-Branch-Control (SBBC) mitigation feature for the guest CPU.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sbbc Domain#sbbc}
        /// </remarks>
        [JsiiProperty(name: "sbbc", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesSbbc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesSbbc? Sbbc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures System Management Mode (SMM) support for the guest, which is required for features like UEFI Secure Boot on some machine types.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#smm Domain#smm}
        /// </remarks>
        [JsiiProperty(name: "smm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesSmm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesSmm? Smm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures QEMU’s TCG (software CPU emulation) feature block for fine-grained tuning of emulation behavior when TCG is in use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tcg Domain#tcg}
        /// </remarks>
        [JsiiProperty(name: "tcg", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesTcg\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesTcg? Tcg
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables the Viridian (Hyper-V enlightenment) feature block for the guest;</summary>
        /// <remarks>
        /// when this presence-boolean is true the viridian feature element is emitted, otherwise it is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#viridian Domain#viridian}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "viridian", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Viridian
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#virtualization Domain#virtualization}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "virtualization", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Virtualization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vm_core_info Domain#vm_core_info}
        /// </remarks>
        [JsiiProperty(name: "vmCoreInfo", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesVmCoreInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesVmCoreInfo? VmCoreInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vm_port Domain#vm_port}
        /// </remarks>
        [JsiiProperty(name: "vmPort", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesVmPort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesVmPort? VmPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures Xen-specific paravirtualization compatibility features for the guest when running under QEMU/KVM with Xen emulation options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xen Domain#xen}
        /// </remarks>
        [JsiiProperty(name: "xen", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesXen\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesXen? Xen
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeatures), fullyQualifiedName: "libvirt.domain.DomainFeatures")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls exposure of ACPI support to the guest;</summary>
            /// <remarks>
            /// presence of this element enables ACPI, while its omission leaves it at libvirt’s default behavior.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Acpi
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures the Advanced Interrupt Architecture (AIA) feature for the guest CPU/machine, with the specific mode or value being user‑provided according to hypervisor support.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#aia Domain#aia}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aia", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesAia\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesAia? Aia
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesAia?>();
            }

            /// <summary>Enables inclusion of the APIC (Advanced Programmable Interrupt Controller) feature block for the guest;</summary>
            /// <remarks>
            /// presence of this block allows configuring APIC-related behavior such as end-of-interrupt handling.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#apic Domain#apic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesApic\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesApic? Apic
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesApic?>();
            }

            /// <summary>Enables configuration of asynchronous teardown support for the guest;</summary>
            /// <remarks>
            /// when present, it allows controlling whether the hypervisor uses async teardown semantics.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#async_teardown Domain#async_teardown}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "asyncTeardown", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesAsyncTeardown\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesAsyncTeardown? AsyncTeardown
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesAsyncTeardown?>();
            }

            /// <summary>Configures per-domain Linux capability controls, allowing fine-grained enabling or disabling of specific capabilities inside the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#capabilities Domain#capabilities}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilities\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilities? Capabilities
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilities?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ccf_assist Domain#ccf_assist}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ccfAssist", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCcfAssist\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCcfAssist? CcfAssist
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCcfAssist?>();
            }

            /// <summary>Configures the "cfpc" CPU feature (a speculative-execution/flush-control mitigation) policy for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cfpc Domain#cfpc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cfpc", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCfpc\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCfpc? Cfpc
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCfpc?>();
            }

            /// <summary>Configures the ARM Generic Interrupt Controller (GIC) feature for the guest, allowing selection or control of the emulated GIC model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#gic Domain#gic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesGic\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesGic? Gic
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesGic?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hap Domain#hap}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHap\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHap? Hap
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHap?>();
            }

            /// <summary>Configures the hashed page table (HPT) feature used by some PowerPC guests, including its size and resizing behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hpt Domain#hpt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hpt", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHpt\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHpt? Hpt
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHpt?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#htm Domain#htm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "htm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHtm\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHtm? Htm
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHtm?>();
            }

            /// <summary>Enables configuration of Hyper-V enlightenment features for the guest when running on a Hyper-V-capable hypervisor.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hyper_v Domain#hyper_v}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hyperV", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperV\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperV? HyperV
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperV?>();
            }

            /// <summary>Enables configuration of the Instruction Based Sampling (IBS) CPU feature on supported AMD guests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ibs Domain#ibs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ibs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesIbs\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesIbs? Ibs
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesIbs?>();
            }

            /// <summary>Configures the emulation mode for the virtual IOAPIC used for interrupt routing in the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ioapic Domain#ioapic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioapic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesIoapic\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesIoapic? Ioapic
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesIoapic?>();
            }

            /// <summary>Enables configuration of KVM-specific CPU or machine features via its child elements (for example, toggling individual KVM feature flags).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#kvm Domain#kvm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kvm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvm\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesKvm? Kvm
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesKvm?>();
            }

            /// <summary>Configures handling of unknown/unsupported model-specific registers (MSRs) encountered in the guest, controlling whether guest MSR accesses can be ignored or cause failures.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#msrs Domain#msrs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "msrs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesMsrs\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesMsrs? Msrs
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesMsrs?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nested_hv Domain#nested_hv}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nestedHv", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesNestedHv\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesNestedHv? NestedHv
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesNestedHv?>();
            }

            /// <summary>Enables or disables Physical Address Extension (PAE) support for the guest;</summary>
            /// <remarks>
            /// when set true the PAE feature element is emitted, when false or unset it is omitted.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pae Domain#pae}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pae", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Pae
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pmu Domain#pmu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pmu", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPmu\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesPmu? Pmu
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesPmu?>();
            }

            /// <summary>Enables or disables the hypervisor’s private networking feature for the guest;</summary>
            /// <remarks>
            /// when set true the privnet feature element is emitted, when false or unset it is omitted.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#priv_net Domain#priv_net}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privNet", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PrivNet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ps2 Domain#ps2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ps2", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPs2\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesPs2? Ps2
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesPs2?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pv_spinlock Domain#pv_spinlock}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pvSpinlock", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPvSpinlock\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesPvSpinlock? PvSpinlock
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesPvSpinlock?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ras Domain#ras}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ras", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesRas\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesRas? Ras
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesRas?>();
            }

            /// <summary>Configures the Spectre-Boundary-Branch-Control (SBBC) mitigation feature for the guest CPU.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sbbc Domain#sbbc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sbbc", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesSbbc\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesSbbc? Sbbc
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesSbbc?>();
            }

            /// <summary>Configures System Management Mode (SMM) support for the guest, which is required for features like UEFI Secure Boot on some machine types.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#smm Domain#smm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesSmm\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesSmm? Smm
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesSmm?>();
            }

            /// <summary>Configures QEMU’s TCG (software CPU emulation) feature block for fine-grained tuning of emulation behavior when TCG is in use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tcg Domain#tcg}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcg", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesTcg\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesTcg? Tcg
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesTcg?>();
            }

            /// <summary>Enables or disables the Viridian (Hyper-V enlightenment) feature block for the guest;</summary>
            /// <remarks>
            /// when this presence-boolean is true the viridian feature element is emitted, otherwise it is omitted.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#viridian Domain#viridian}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "viridian", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Viridian
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#virtualization Domain#virtualization}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualization", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Virtualization
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vm_core_info Domain#vm_core_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vmCoreInfo", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesVmCoreInfo\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesVmCoreInfo? VmCoreInfo
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesVmCoreInfo?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vm_port Domain#vm_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vmPort", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesVmPort\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesVmPort? VmPort
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesVmPort?>();
            }

            /// <summary>Configures Xen-specific paravirtualization compatibility features for the guest when running under QEMU/KVM with Xen emulation options.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xen Domain#xen}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xen", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesXen\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesXen? Xen
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesXen?>();
            }
        }
    }
}
