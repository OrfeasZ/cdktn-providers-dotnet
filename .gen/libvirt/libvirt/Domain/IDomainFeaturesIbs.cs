using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesIbs), fullyQualifiedName: "libvirt.domain.DomainFeaturesIbs")]
    public interface IDomainFeaturesIbs
    {
        /// <summary>Sets the state of the IBS feature, usually "on" or "off";</summary>
        /// <remarks>
        /// this attribute is required when ibs is present and must be explicitly specified.
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

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesIbs), fullyQualifiedName: "libvirt.domain.DomainFeaturesIbs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesIbs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the state of the IBS feature, usually "on" or "off";</summary>
            /// <remarks>
            /// this attribute is required when ibs is present and must be explicitly specified.
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
