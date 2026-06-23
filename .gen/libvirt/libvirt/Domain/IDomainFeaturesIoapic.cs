using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesIoapic), fullyQualifiedName: "libvirt.domain.DomainFeaturesIoapic")]
    public interface IDomainFeaturesIoapic
    {
        /// <summary>Selects the IOAPIC emulation driver, typically using values like "qemu" or "kvm";</summary>
        /// <remarks>
        /// the exact string is user-provided but must be supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Driver
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesIoapic), fullyQualifiedName: "libvirt.domain.DomainFeaturesIoapic")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesIoapic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Selects the IOAPIC emulation driver, typically using values like "qemu" or "kvm";</summary>
            /// <remarks>
            /// the exact string is user-provided but must be supported by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Driver
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
