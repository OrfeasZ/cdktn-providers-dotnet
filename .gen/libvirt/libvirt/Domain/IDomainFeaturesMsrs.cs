using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesMsrs), fullyQualifiedName: "libvirt.domain.DomainFeaturesMsrs")]
    public interface IDomainFeaturesMsrs
    {
        /// <summary>Sets the policy for unknown MSR accesses by the guest;</summary>
        /// <remarks>
        /// valid values are driver-specific (commonly "ignore", "warn", or "fault") and must be provided explicitly.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unknown Domain#unknown}
        /// </remarks>
        [JsiiProperty(name: "unknown", typeJson: "{\"primitive\":\"string\"}")]
        string Unknown
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesMsrs), fullyQualifiedName: "libvirt.domain.DomainFeaturesMsrs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesMsrs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the policy for unknown MSR accesses by the guest;</summary>
            /// <remarks>
            /// valid values are driver-specific (commonly "ignore", "warn", or "fault") and must be provided explicitly.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unknown Domain#unknown}
            /// </remarks>
            [JsiiProperty(name: "unknown", typeJson: "{\"primitive\":\"string\"}")]
            public string Unknown
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
