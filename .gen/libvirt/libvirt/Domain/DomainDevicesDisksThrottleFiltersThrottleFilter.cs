using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksThrottleFiltersThrottleFilter")]
    public class DomainDevicesDisksThrottleFiltersThrottleFilter : libvirt.Domain.IDomainDevicesDisksThrottleFiltersThrottleFilter
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
        public string Group
        {
            get;
            set;
        }
    }
}
