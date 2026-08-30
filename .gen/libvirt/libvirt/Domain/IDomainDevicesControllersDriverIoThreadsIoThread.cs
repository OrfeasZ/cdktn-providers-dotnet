using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesControllersDriverIoThreadsIoThread), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersDriverIoThreadsIoThread")]
    public interface IDomainDevicesControllersDriverIoThreadsIoThread
    {
        /// <summary>Identifies the IOThread instance used by this controller entry;</summary>
        /// <remarks>
        /// when omitted libvirt computes/assigns it, and when set it must match a valid IOThread id for the domain.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        double Id
        {
            get;
        }

        /// <summary>Defines one or more queues handled by this IOThread for the controller, allowing fine-grained mapping of queue ids to threads.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queues Domain#queues}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThreadQueues" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "queues", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverIoThreadsIoThreadQueues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Queues
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesControllersDriverIoThreadsIoThread), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersDriverIoThreadsIoThread")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThread
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifies the IOThread instance used by this controller entry;</summary>
            /// <remarks>
            /// when omitted libvirt computes/assigns it, and when set it must match a valid IOThread id for the domain.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
            public double Id
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Defines one or more queues handled by this IOThread for the controller, allowing fine-grained mapping of queue ids to threads.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queues Domain#queues}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThreadQueues" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queues", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverIoThreadsIoThreadQueues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Queues
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
