using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksThrottleFiltersThrottleFilter), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksThrottleFiltersThrottleFilter")]
    public interface IDomainDevicesDisksThrottleFiltersThrottleFilter
    {
        /// <summary>Sets the name of the throttle group that this disk’s throttle filter should attach to;</summary>
        /// <remarks>
        /// must match an existing group defined under domain throttlegroups.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#group Domain#group}
        /// </remarks>
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}")]
        string Group
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksThrottleFiltersThrottleFilter), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksThrottleFiltersThrottleFilter")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksThrottleFiltersThrottleFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the name of the throttle group that this disk’s throttle filter should attach to;</summary>
            /// <remarks>
            /// must match an existing group defined under domain throttlegroups.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#group Domain#group}
            /// </remarks>
            [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}")]
            public string Group
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
