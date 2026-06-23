using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainIoThreadIDs), fullyQualifiedName: "libvirt.domain.DomainIoThreadIDs")]
    public interface IDomainIoThreadIDs
    {
        /// <summary>Defines an individual IOThread entry within the IOThread ID set, optionally with per-thread tuning such as polling.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_threads Domain#io_threads}
        /// </remarks>
        [JsiiProperty(name: "ioThreads", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainIoThreadIDsIoThreads\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IoThreads
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainIoThreadIDs), fullyQualifiedName: "libvirt.domain.DomainIoThreadIDs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainIoThreadIDs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines an individual IOThread entry within the IOThread ID set, optionally with per-thread tuning such as polling.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_threads Domain#io_threads}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThreads", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainIoThreadIDsIoThreads\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IoThreads
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
