using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainUpdate), fullyQualifiedName: "libvirt.domain.DomainUpdate")]
    public interface IDomainUpdate
    {
        /// <summary>Experimental: request a guest shutdown and wait for shutoff before forcing a stop during update.</summary>
        /// <remarks>
        /// Subject to change in future releases.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shutdown Domain#shutdown}
        /// </remarks>
        [JsiiProperty(name: "shutdown", typeJson: "{\"fqn\":\"libvirt.domain.DomainUpdateShutdown\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainUpdateShutdown? Shutdown
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainUpdate), fullyQualifiedName: "libvirt.domain.DomainUpdate")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainUpdate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Experimental: request a guest shutdown and wait for shutoff before forcing a stop during update.</summary>
            /// <remarks>
            /// Subject to change in future releases.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shutdown Domain#shutdown}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shutdown", typeJson: "{\"fqn\":\"libvirt.domain.DomainUpdateShutdown\"}", isOptional: true)]
            public libvirt.Domain.IDomainUpdateShutdown? Shutdown
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainUpdateShutdown?>();
            }
        }
    }
}
