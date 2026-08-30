using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesXen), fullyQualifiedName: "libvirt.domain.DomainFeaturesXen")]
    public interface IDomainFeaturesXen
    {
        /// <summary>Enables or disables use of the host’s E820 memory map when exposing Xen emulation to the guest, typically as a yes/no style toggle (value is user-provided such as "on"/"off").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#e820host Domain#e820host}
        /// </remarks>
        [JsiiProperty(name: "e820Host", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesXenE820Host\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesXenE820Host? E820Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of Xen passthrough-related features for the domain;</summary>
        /// <remarks>
        /// presence of this block determines whether passthrough sub‑options can be set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passthrough Domain#passthrough}
        /// </remarks>
        [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesXenPassthrough\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesXenPassthrough? Passthrough
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesXen), fullyQualifiedName: "libvirt.domain.DomainFeaturesXen")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesXen
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables or disables use of the host’s E820 memory map when exposing Xen emulation to the guest, typically as a yes/no style toggle (value is user-provided such as "on"/"off").</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#e820host Domain#e820host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "e820Host", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesXenE820Host\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesXenE820Host? E820Host
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesXenE820Host?>();
            }

            /// <summary>Enables configuration of Xen passthrough-related features for the domain;</summary>
            /// <remarks>
            /// presence of this block determines whether passthrough sub‑options can be set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passthrough Domain#passthrough}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesXenPassthrough\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesXenPassthrough? Passthrough
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesXenPassthrough?>();
            }
        }
    }
}
