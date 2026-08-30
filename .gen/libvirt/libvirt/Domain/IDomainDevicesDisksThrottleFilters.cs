using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksThrottleFilters), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksThrottleFilters")]
    public interface IDomainDevicesDisksThrottleFilters
    {
        /// <summary>Declares a single throttle filter element referencing a named throttle group to control this disk’s I/O limits.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#throttle_filter Domain#throttle_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksThrottleFiltersThrottleFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "throttleFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksThrottleFiltersThrottleFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThrottleFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksThrottleFilters), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksThrottleFilters")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksThrottleFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Declares a single throttle filter element referencing a named throttle group to control this disk’s I/O limits.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#throttle_filter Domain#throttle_filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksThrottleFiltersThrottleFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "throttleFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksThrottleFiltersThrottleFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThrottleFilter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
