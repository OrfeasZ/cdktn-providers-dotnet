using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDestroy), fullyQualifiedName: "libvirt.domain.DomainDestroy")]
    public interface IDomainDestroy
    {
        /// <summary>Experimental: request graceful behavior when using DomainDestroyFlags during domain stop. Subject to change in future releases.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#graceful Domain#graceful}
        /// </remarks>
        [JsiiProperty(name: "graceful", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Graceful
        {
            get
            {
                return null;
            }
        }

        /// <summary>Experimental: request a guest shutdown and wait for shutoff before undefine. Subject to change in future releases.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shutdown Domain#shutdown}
        /// </remarks>
        [JsiiProperty(name: "shutdown", typeJson: "{\"fqn\":\"libvirt.domain.DomainDestroyShutdown\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDestroyShutdown? Shutdown
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDestroy), fullyQualifiedName: "libvirt.domain.DomainDestroy")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDestroy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Experimental: request graceful behavior when using DomainDestroyFlags during domain stop. Subject to change in future releases.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#graceful Domain#graceful}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "graceful", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Graceful
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Experimental: request a guest shutdown and wait for shutoff before undefine. Subject to change in future releases.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shutdown Domain#shutdown}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shutdown", typeJson: "{\"fqn\":\"libvirt.domain.DomainDestroyShutdown\"}", isOptional: true)]
            public libvirt.Domain.IDomainDestroyShutdown? Shutdown
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDestroyShutdown?>();
            }
        }
    }
}
