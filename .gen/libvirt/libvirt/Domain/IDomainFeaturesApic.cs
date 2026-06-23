using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesApic), fullyQualifiedName: "libvirt.domain.DomainFeaturesApic")]
    public interface IDomainFeaturesApic
    {
        /// <summary>Sets whether APIC end-of-interrupt (EOI) optimization is enabled for the guest;</summary>
        /// <remarks>
        /// valid values are user-provided strings typically interpreted as "on" or "off" by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#eoi Domain#eoi}
        /// </remarks>
        [JsiiProperty(name: "eoi", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Eoi
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesApic), fullyQualifiedName: "libvirt.domain.DomainFeaturesApic")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesApic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets whether APIC end-of-interrupt (EOI) optimization is enabled for the guest;</summary>
            /// <remarks>
            /// valid values are user-provided strings typically interpreted as "on" or "off" by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#eoi Domain#eoi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eoi", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Eoi
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
