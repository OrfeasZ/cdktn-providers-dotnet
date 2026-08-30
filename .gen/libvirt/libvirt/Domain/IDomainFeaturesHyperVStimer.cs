using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesHyperVStimer), fullyQualifiedName: "libvirt.domain.DomainFeaturesHyperVStimer")]
    public interface IDomainFeaturesHyperVStimer
    {
        /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#direct Domain#direct}
        /// </remarks>
        [JsiiProperty(name: "direct", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVStimerDirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesHyperVStimerDirect? Direct
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the PS2 feature state;</summary>
        /// <remarks>
        /// valid values are usually "on" or "off" to enable or disable the PS/2-related feature for the domain.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#state Domain#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesHyperVStimer), fullyQualifiedName: "libvirt.domain.DomainFeaturesHyperVStimer")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesHyperVStimer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether the hypervisor exposes legacy PS/2 controller semantics as a CPU/machine feature toggle for the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#direct Domain#direct}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direct", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVStimerDirect\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesHyperVStimerDirect? Direct
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesHyperVStimerDirect?>();
            }

            /// <summary>Sets the PS2 feature state;</summary>
            /// <remarks>
            /// valid values are usually "on" or "off" to enable or disable the PS/2-related feature for the domain.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#state Domain#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
