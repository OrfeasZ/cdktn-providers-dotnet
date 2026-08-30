using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesHyperV), fullyQualifiedName: "libvirt.domain.DomainFeaturesHyperV")]
    public interface IDomainFeaturesHyperV
    {
        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#avic Domain#avic}
        /// </remarks>
        [JsiiProperty(name: "avic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVAvic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVAvic? Avic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emsr_bitmap Domain#emsr_bitmap}
        /// </remarks>
        [JsiiProperty(name: "emsrBitmap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVEmsrBitmap\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVEmsrBitmap? EmsrBitmap
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#evmcs Domain#evmcs}
        /// </remarks>
        [JsiiProperty(name: "evmcs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVEvmcs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVEvmcs? Evmcs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#frequencies Domain#frequencies}
        /// </remarks>
        [JsiiProperty(name: "frequencies", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVFrequencies\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVFrequencies? Frequencies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ipi Domain#ipi}
        /// </remarks>
        [JsiiProperty(name: "ipi", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVIpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVIpi? Ipi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the Hyper-V enlightenment mode for the domain (for example, "custom" vs.</summary>
        /// <remarks>
        /// driver-specific modes); the exact allowed values are user-provided and depend on the libvirt/QEMU version.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#re_enlightenment Domain#re_enlightenment}
        /// </remarks>
        [JsiiProperty(name: "reEnlightenment", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVReEnlightenment\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVReEnlightenment? ReEnlightenment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#relaxed Domain#relaxed}
        /// </remarks>
        [JsiiProperty(name: "relaxed", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVRelaxed\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVRelaxed? Relaxed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#reset Domain#reset}
        /// </remarks>
        [JsiiProperty(name: "reset", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVReset\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVReset? Reset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#runtime Domain#runtime}
        /// </remarks>
        [JsiiProperty(name: "runtime", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVRuntime\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVRuntime? Runtime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the Hyper-V spinlock enlightenment, which can reduce CPU waste on spinlocks by triggering a fallback after a configurable number of retries.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spinlocks Domain#spinlocks}
        /// </remarks>
        [JsiiProperty(name: "spinlocks", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVSpinlocks\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVSpinlocks? Spinlocks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the Hyper-V synthetic timer (stimer) feature, which provides paravirtualized timer support to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#stimer Domain#stimer}
        /// </remarks>
        [JsiiProperty(name: "stimer", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVStimer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVStimer? Stimer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#synic Domain#synic}
        /// </remarks>
        [JsiiProperty(name: "synic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVSynic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVSynic? Synic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of Hyper-V TLB flush enlightenment features for the guest;</summary>
        /// <remarks>
        /// presence of this block allows selecting specific flush modes via its children.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tlb_flush Domain#tlb_flush}
        /// </remarks>
        [JsiiProperty(name: "tlbFlush", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlush\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVTlbFlush? TlbFlush
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vapic Domain#vapic}
        /// </remarks>
        [JsiiProperty(name: "vapic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVapic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVVapic? Vapic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of a custom Hyper-V CPUID vendor ID string presented to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vendor_id Domain#vendor_id}
        /// </remarks>
        [JsiiProperty(name: "vendorId", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVendorId\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVVendorId? VendorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vp_index Domain#vp_index}
        /// </remarks>
        [JsiiProperty(name: "vpIndex", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVpIndex\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVVpIndex? VpIndex
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xmm_input Domain#xmm_input}
        /// </remarks>
        [JsiiProperty(name: "xmmInput", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVXmmInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVXmmInput? XmmInput
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesHyperV), fullyQualifiedName: "libvirt.domain.DomainFeaturesHyperV")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesHyperV
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#avic Domain#avic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "avic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVAvic\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVAvic? Avic
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVAvic?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emsr_bitmap Domain#emsr_bitmap}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emsrBitmap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVEmsrBitmap\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVEmsrBitmap? EmsrBitmap
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVEmsrBitmap?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#evmcs Domain#evmcs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "evmcs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVEvmcs\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVEvmcs? Evmcs
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVEvmcs?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#frequencies Domain#frequencies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frequencies", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVFrequencies\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVFrequencies? Frequencies
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVFrequencies?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ipi Domain#ipi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipi", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVIpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVIpi? Ipi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVIpi?>();
            }

            /// <summary>Sets the Hyper-V enlightenment mode for the domain (for example, "custom" vs.</summary>
            /// <remarks>
            /// driver-specific modes); the exact allowed values are user-provided and depend on the libvirt/QEMU version.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#re_enlightenment Domain#re_enlightenment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reEnlightenment", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVReEnlightenment\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVReEnlightenment? ReEnlightenment
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVReEnlightenment?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#relaxed Domain#relaxed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relaxed", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVRelaxed\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVRelaxed? Relaxed
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVRelaxed?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#reset Domain#reset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reset", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVReset\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVReset? Reset
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVReset?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#runtime Domain#runtime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtime", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVRuntime\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVRuntime? Runtime
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVRuntime?>();
            }

            /// <summary>Configures the Hyper-V spinlock enlightenment, which can reduce CPU waste on spinlocks by triggering a fallback after a configurable number of retries.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spinlocks Domain#spinlocks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spinlocks", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVSpinlocks\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVSpinlocks? Spinlocks
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVSpinlocks?>();
            }

            /// <summary>Configures the Hyper-V synthetic timer (stimer) feature, which provides paravirtualized timer support to the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#stimer Domain#stimer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stimer", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVStimer\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVStimer? Stimer
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVStimer?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#synic Domain#synic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "synic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVSynic\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVSynic? Synic
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVSynic?>();
            }

            /// <summary>Enables configuration of Hyper-V TLB flush enlightenment features for the guest;</summary>
            /// <remarks>
            /// presence of this block allows selecting specific flush modes via its children.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tlb_flush Domain#tlb_flush}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlbFlush", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlush\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVTlbFlush? TlbFlush
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVTlbFlush?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vapic Domain#vapic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vapic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVapic\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVVapic? Vapic
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVVapic?>();
            }

            /// <summary>Enables configuration of a custom Hyper-V CPUID vendor ID string presented to the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vendor_id Domain#vendor_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vendorId", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVendorId\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVVendorId? VendorId
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVVendorId?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vp_index Domain#vp_index}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpIndex", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVpIndex\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVVpIndex? VpIndex
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVVpIndex?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xmm_input Domain#xmm_input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xmmInput", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVXmmInput\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVXmmInput? XmmInput
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVXmmInput?>();
            }
        }
    }
}
