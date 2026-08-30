using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainPerf), fullyQualifiedName: "libvirt.domain.DomainPerf")]
    public interface IDomainPerf
    {
        /// <summary>Defines one or more performance monitoring events to track for the guest, each identified by a name and an enabled flag.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#performance-monitoring-events">https://libvirt.org/formatdomain.html#performance-monitoring-events</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#events Domain#events}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainPerfEvents" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "events", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainPerfEvents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Events
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainPerf), fullyQualifiedName: "libvirt.domain.DomainPerf")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainPerf
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines one or more performance monitoring events to track for the guest, each identified by a name and an enabled flag.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#performance-monitoring-events">https://libvirt.org/formatdomain.html#performance-monitoring-events</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#events Domain#events}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainPerfEvents" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "events", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainPerfEvents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Events
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
