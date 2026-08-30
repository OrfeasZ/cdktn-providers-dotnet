using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesXenE820Host), fullyQualifiedName: "libvirt.domain.DomainFeaturesXenE820Host")]
    public interface IDomainFeaturesXenE820Host
    {
        /// <summary>Sets whether the Xen e820_host feature is enabled for the guest;</summary>
        /// <remarks>
        /// accepts the string values "on" or "off" and is required when the xen.e820host feature is present.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#state Domain#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesXenE820Host), fullyQualifiedName: "libvirt.domain.DomainFeaturesXenE820Host")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesXenE820Host
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets whether the Xen e820_host feature is enabled for the guest;</summary>
            /// <remarks>
            /// accepts the string values "on" or "off" and is required when the xen.e820host feature is present.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#state Domain#state}
            /// </remarks>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
