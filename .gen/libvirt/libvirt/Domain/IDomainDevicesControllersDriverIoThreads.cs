using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesControllersDriverIoThreads), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersDriverIoThreads")]
    public interface IDomainDevicesControllersDriverIoThreads
    {
        /// <summary>Describes a single IOThread used by the controller, optionally including an explicit id and associated queues.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_thread Domain#io_thread}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThread" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ioThread", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverIoThreadsIoThread\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IoThread
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesControllersDriverIoThreads), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersDriverIoThreads")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesControllersDriverIoThreads
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Describes a single IOThread used by the controller, optionally including an explicit id and associated queues.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_thread Domain#io_thread}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThread" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThread", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverIoThreadsIoThread\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IoThread
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
