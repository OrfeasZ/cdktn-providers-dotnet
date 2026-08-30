using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesCapabilitiesMkNod), fullyQualifiedName: "libvirt.domain.DomainFeaturesCapabilitiesMkNod")]
    public interface IDomainFeaturesCapabilitiesMkNod
    {
        /// <summary>Sets whether the guest is allowed to use the host wake alarm capability;</summary>
        /// <remarks>
        /// accepts the usual feature state values such as "on", "off", or "default" depending on hypervisor support.
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

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesCapabilitiesMkNod), fullyQualifiedName: "libvirt.domain.DomainFeaturesCapabilitiesMkNod")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesCapabilitiesMkNod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets whether the guest is allowed to use the host wake alarm capability;</summary>
            /// <remarks>
            /// accepts the usual feature state values such as "on", "off", or "default" depending on hypervisor support.
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
