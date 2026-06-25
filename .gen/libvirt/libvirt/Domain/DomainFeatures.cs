using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainFeatures")]
    public class DomainFeatures : libvirt.Domain.IDomainFeatures
    {
        private object? _acpi;

        /// <summary>Controls exposure of ACPI support to the guest;</summary>
        /// <remarks>
        /// presence of this element enables ACPI, while its omission leaves it at libvirt’s default behavior.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Acpi
        {
            get => _acpi;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _acpi = value;
            }
        }

        /// <summary>Configures the Advanced Interrupt Architecture (AIA) feature for the guest CPU/machine, with the specific mode or value being user‑provided according to hypervisor support.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#aia Domain#aia}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aia", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesAia\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesAia? Aia
        {
            get;
            set;
        }

        /// <summary>Enables inclusion of the APIC (Advanced Programmable Interrupt Controller) feature block for the guest;</summary>
        /// <remarks>
        /// presence of this block allows configuring APIC-related behavior such as end-of-interrupt handling.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#apic Domain#apic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesApic\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesApic? Apic
        {
            get;
            set;
        }

        /// <summary>Enables configuration of asynchronous teardown support for the guest;</summary>
        /// <remarks>
        /// when present, it allows controlling whether the hypervisor uses async teardown semantics.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#async_teardown Domain#async_teardown}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "asyncTeardown", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesAsyncTeardown\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesAsyncTeardown? AsyncTeardown
        {
            get;
            set;
        }

        /// <summary>Configures per-domain Linux capability controls, allowing fine-grained enabling or disabling of specific capabilities inside the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#capabilities Domain#capabilities}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilities\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilities? Capabilities
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ccf_assist Domain#ccf_assist}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ccfAssist", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCcfAssist\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCcfAssist? CcfAssist
        {
            get;
            set;
        }

        /// <summary>Configures the "cfpc" CPU feature (a speculative-execution/flush-control mitigation) policy for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cfpc Domain#cfpc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cfpc", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCfpc\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCfpc? Cfpc
        {
            get;
            set;
        }

        /// <summary>Configures the ARM Generic Interrupt Controller (GIC) feature for the guest, allowing selection or control of the emulated GIC model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gic Domain#gic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesGic\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesGic? Gic
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hap Domain#hap}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHap\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesHap? Hap
        {
            get;
            set;
        }

        /// <summary>Configures the hashed page table (HPT) feature used by some PowerPC guests, including its size and resizing behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hpt Domain#hpt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hpt", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHpt\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesHpt? Hpt
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#htm Domain#htm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "htm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHtm\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesHtm? Htm
        {
            get;
            set;
        }

        /// <summary>Enables configuration of Hyper-V enlightenment features for the guest when running on a Hyper-V-capable hypervisor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hyper_v Domain#hyper_v}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hyperV", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperV\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesHyperV? HyperV
        {
            get;
            set;
        }

        /// <summary>Enables configuration of the Instruction Based Sampling (IBS) CPU feature on supported AMD guests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ibs Domain#ibs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ibs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesIbs\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesIbs? Ibs
        {
            get;
            set;
        }

        /// <summary>Configures the emulation mode for the virtual IOAPIC used for interrupt routing in the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ioapic Domain#ioapic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioapic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesIoapic\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesIoapic? Ioapic
        {
            get;
            set;
        }

        /// <summary>Enables configuration of KVM-specific CPU or machine features via its child elements (for example, toggling individual KVM feature flags).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#kvm Domain#kvm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kvm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvm\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesKvm? Kvm
        {
            get;
            set;
        }

        /// <summary>Configures handling of unknown/unsupported model-specific registers (MSRs) encountered in the guest, controlling whether guest MSR accesses can be ignored or cause failures.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#msrs Domain#msrs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "msrs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesMsrs\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesMsrs? Msrs
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nested_hv Domain#nested_hv}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nestedHv", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesNestedHv\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesNestedHv? NestedHv
        {
            get;
            set;
        }

        private object? _pae;

        /// <summary>Enables or disables Physical Address Extension (PAE) support for the guest;</summary>
        /// <remarks>
        /// when set true the PAE feature element is emitted, when false or unset it is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pae Domain#pae}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pae", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Pae
        {
            get => _pae;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pae = value;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pmu Domain#pmu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pmu", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPmu\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesPmu? Pmu
        {
            get;
            set;
        }

        private object? _privNet;

        /// <summary>Enables or disables the hypervisor’s private networking feature for the guest;</summary>
        /// <remarks>
        /// when set true the privnet feature element is emitted, when false or unset it is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#priv_net Domain#priv_net}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privNet", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PrivNet
        {
            get => _privNet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _privNet = value;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ps2 Domain#ps2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ps2", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPs2\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesPs2? Ps2
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pv_spinlock Domain#pv_spinlock}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pvSpinlock", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPvSpinlock\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesPvSpinlock? PvSpinlock
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ras Domain#ras}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ras", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesRas\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesRas? Ras
        {
            get;
            set;
        }

        /// <summary>Configures the Spectre-Boundary-Branch-Control (SBBC) mitigation feature for the guest CPU.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sbbc Domain#sbbc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sbbc", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesSbbc\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesSbbc? Sbbc
        {
            get;
            set;
        }

        /// <summary>Configures System Management Mode (SMM) support for the guest, which is required for features like UEFI Secure Boot on some machine types.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#smm Domain#smm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesSmm\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesSmm? Smm
        {
            get;
            set;
        }

        /// <summary>Configures QEMU’s TCG (software CPU emulation) feature block for fine-grained tuning of emulation behavior when TCG is in use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tcg Domain#tcg}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcg", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesTcg\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesTcg? Tcg
        {
            get;
            set;
        }

        private object? _viridian;

        /// <summary>Enables or disables the Viridian (Hyper-V enlightenment) feature block for the guest;</summary>
        /// <remarks>
        /// when this presence-boolean is true the viridian feature element is emitted, otherwise it is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#viridian Domain#viridian}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "viridian", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Viridian
        {
            get => _viridian;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _viridian = value;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vm_core_info Domain#vm_core_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vmCoreInfo", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesVmCoreInfo\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesVmCoreInfo? VmCoreInfo
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vm_port Domain#vm_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vmPort", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesVmPort\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesVmPort? VmPort
        {
            get;
            set;
        }

        /// <summary>Configures Xen-specific paravirtualization compatibility features for the guest when running under QEMU/KVM with Xen emulation options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#xen Domain#xen}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xen", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesXen\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesXen? Xen
        {
            get;
            set;
        }
    }
}
