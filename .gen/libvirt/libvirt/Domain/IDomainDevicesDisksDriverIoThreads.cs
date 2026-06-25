using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksDriverIoThreads), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverIoThreads")]
    public interface IDomainDevicesDisksDriverIoThreads
    {
        /// <summary>Describes a single IOThread mapping entry for this disk, potentially distributing disk queues across IOThreads.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_thread Domain#io_thread}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksDriverIoThreadsIoThread" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ioThread", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverIoThreadsIoThread\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IoThread
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksDriverIoThreads), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverIoThreads")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksDriverIoThreads
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Describes a single IOThread mapping entry for this disk, potentially distributing disk queues across IOThreads.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_thread Domain#io_thread}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksDriverIoThreadsIoThread" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThread", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverIoThreadsIoThread\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IoThread
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
