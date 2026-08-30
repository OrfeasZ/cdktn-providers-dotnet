using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesSbbc), fullyQualifiedName: "libvirt.domain.DomainFeaturesSbbc")]
    public interface IDomainFeaturesSbbc
    {
        /// <summary>Sets the SBBC mitigation mode as a user-provided value (for example "on", "off", or a model-specific keyword, depending on hypervisor support);</summary>
        /// <remarks>
        /// this attribute is required when sbbc is present.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesSbbc), fullyQualifiedName: "libvirt.domain.DomainFeaturesSbbc")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesSbbc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the SBBC mitigation mode as a user-provided value (for example "on", "off", or a model-specific keyword, depending on hypervisor support);</summary>
            /// <remarks>
            /// this attribute is required when sbbc is present.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
