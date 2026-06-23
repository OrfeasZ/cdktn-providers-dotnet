using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesAia), fullyQualifiedName: "libvirt.domain.DomainFeaturesAia")]
    public interface IDomainFeaturesAia
    {
        /// <summary>Configures the Advanced Interrupt Architecture (AIA) feature state for the domain;</summary>
        /// <remarks>
        /// valid values are user-provided strings such as "on", "off", or mode-specific values as supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesAia), fullyQualifiedName: "libvirt.domain.DomainFeaturesAia")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesAia
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the Advanced Interrupt Architecture (AIA) feature state for the domain;</summary>
            /// <remarks>
            /// valid values are user-provided strings such as "on", "off", or mode-specific values as supported by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
