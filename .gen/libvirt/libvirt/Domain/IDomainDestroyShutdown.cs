using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDestroyShutdown), fullyQualifiedName: "libvirt.domain.DomainDestroyShutdown")]
    public interface IDomainDestroyShutdown
    {
        /// <summary>Experimental: seconds to wait for guest shutdown before failing destroy. Defaults to 30.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#timeout Domain#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDestroyShutdown), fullyQualifiedName: "libvirt.domain.DomainDestroyShutdown")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDestroyShutdown
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Experimental: seconds to wait for guest shutdown before failing destroy. Defaults to 30.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#timeout Domain#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
