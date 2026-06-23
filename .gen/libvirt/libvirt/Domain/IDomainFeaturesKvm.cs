using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesKvm), fullyQualifiedName: "libvirt.domain.DomainFeaturesKvm")]
    public interface IDomainFeaturesKvm
    {
        /// <summary>Configures the KVM dirty-ring feature for tracking guest memory changes via a ring buffer instead of legacy dirty logging, enabling more efficient live migration and dirty-page tracking when supported by the host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dirty_ring Domain#dirty_ring}
        /// </remarks>
        [JsiiProperty(name: "dirtyRing", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmDirtyRing\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesKvmDirtyRing? DirtyRing
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hidden Domain#hidden}
        /// </remarks>
        [JsiiProperty(name: "hidden", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHidden\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesKvmHidden? Hidden
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hint_dedicated Domain#hint_dedicated}
        /// </remarks>
        [JsiiProperty(name: "hintDedicated", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHintDedicated\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesKvmHintDedicated? HintDedicated
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#poll_control Domain#poll_control}
        /// </remarks>
        [JsiiProperty(name: "pollControl", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPollControl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesKvmPollControl? PollControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pvipi Domain#pvipi}
        /// </remarks>
        [JsiiProperty(name: "pvipi", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPvipi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesKvmPvipi? Pvipi
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesKvm), fullyQualifiedName: "libvirt.domain.DomainFeaturesKvm")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesKvm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the KVM dirty-ring feature for tracking guest memory changes via a ring buffer instead of legacy dirty logging, enabling more efficient live migration and dirty-page tracking when supported by the host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dirty_ring Domain#dirty_ring}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dirtyRing", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmDirtyRing\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesKvmDirtyRing? DirtyRing
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesKvmDirtyRing?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hidden Domain#hidden}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hidden", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHidden\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesKvmHidden? Hidden
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesKvmHidden?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hint_dedicated Domain#hint_dedicated}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hintDedicated", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHintDedicated\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesKvmHintDedicated? HintDedicated
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesKvmHintDedicated?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#poll_control Domain#poll_control}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pollControl", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPollControl\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesKvmPollControl? PollControl
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesKvmPollControl?>();
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pvipi Domain#pvipi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pvipi", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPvipi\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesKvmPvipi? Pvipi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesKvmPvipi?>();
            }
        }
    }
}
