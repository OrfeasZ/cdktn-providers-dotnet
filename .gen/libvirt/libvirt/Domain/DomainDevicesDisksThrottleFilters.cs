using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksThrottleFilters")]
    public class DomainDevicesDisksThrottleFilters : libvirt.Domain.IDomainDevicesDisksThrottleFilters
    {
        private object? _throttleFilter;

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
            get => _throttleFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesDisksThrottleFiltersThrottleFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksThrottleFiltersThrottleFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _throttleFilter = value;
            }
        }
    }
}
