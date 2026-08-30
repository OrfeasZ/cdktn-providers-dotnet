using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesGic), fullyQualifiedName: "libvirt.domain.DomainFeaturesGic")]
    public interface IDomainFeaturesGic
    {
        /// <summary>Sets the desired GIC hardware version presented to the guest, such as "2" or "3", with the exact allowed values depending on the guest architecture and machine type.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#version Domain#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesGic), fullyQualifiedName: "libvirt.domain.DomainFeaturesGic")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesGic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the desired GIC hardware version presented to the guest, such as "2" or "3", with the exact allowed values depending on the guest architecture and machine type.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#version Domain#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
