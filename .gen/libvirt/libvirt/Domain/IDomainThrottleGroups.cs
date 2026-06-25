using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainThrottleGroups), fullyQualifiedName: "libvirt.domain.DomainThrottleGroups")]
    public interface IDomainThrottleGroups
    {
        /// <summary>Defines a single disk throttle group, including its group name and optional aggregate byte and IOPS limits used by disks that join this group.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#throttle_groups Domain#throttle_groups}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainThrottleGroupsThrottleGroups" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "throttleGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainThrottleGroupsThrottleGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThrottleGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainThrottleGroups), fullyQualifiedName: "libvirt.domain.DomainThrottleGroups")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainThrottleGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines a single disk throttle group, including its group name and optional aggregate byte and IOPS limits used by disks that join this group.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#throttle_groups Domain#throttle_groups}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainThrottleGroupsThrottleGroups" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "throttleGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainThrottleGroupsThrottleGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThrottleGroups
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
