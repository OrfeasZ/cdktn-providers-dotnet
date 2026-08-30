using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesCfpc), fullyQualifiedName: "libvirt.domain.DomainFeaturesCfpc")]
    public interface IDomainFeaturesCfpc
    {
        /// <summary>Sets the cfpc policy value;</summary>
        /// <remarks>
        /// libvirt accepts specific strings such as "on", "off", "workaround", "broken", or "default" depending on the mitigation mode supported by the hypervisor.
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

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesCfpc), fullyQualifiedName: "libvirt.domain.DomainFeaturesCfpc")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesCfpc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the cfpc policy value;</summary>
            /// <remarks>
            /// libvirt accepts specific strings such as "on", "off", "workaround", "broken", or "default" depending on the mitigation mode supported by the hypervisor.
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
