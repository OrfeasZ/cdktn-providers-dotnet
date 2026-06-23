using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainFeaturesKvm")]
    public class DomainFeaturesKvm : libvirt.Domain.IDomainFeaturesKvm
    {
        /// <summary>Configures the KVM dirty-ring feature for tracking guest memory changes via a ring buffer instead of legacy dirty logging, enabling more efficient live migration and dirty-page tracking when supported by the host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dirty_ring Domain#dirty_ring}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dirtyRing", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmDirtyRing\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesKvmDirtyRing? DirtyRing
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hidden Domain#hidden}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hidden", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHidden\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesKvmHidden? Hidden
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hint_dedicated Domain#hint_dedicated}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hintDedicated", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHintDedicated\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesKvmHintDedicated? HintDedicated
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#poll_control Domain#poll_control}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pollControl", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPollControl\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesKvmPollControl? PollControl
        {
            get;
            set;
        }

        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pvipi Domain#pvipi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pvipi", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPvipi\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesKvmPvipi? Pvipi
        {
            get;
            set;
        }
    }
}
