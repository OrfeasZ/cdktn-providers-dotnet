using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainThrottleGroups")]
    public class DomainThrottleGroups : libvirt.Domain.IDomainThrottleGroups
    {
        private object? _throttleGroups;

        /// <summary>Defines a single disk throttle group, including its group name and optional aggregate byte and IOPS limits used by disks that join this group.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#disk-throttle-group-management">https://libvirt.org/formatdomain.html#disk-throttle-group-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#throttle_groups Domain#throttle_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "throttleGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainThrottleGroupsThrottleGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ThrottleGroups
        {
            get => _throttleGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainThrottleGroupsThrottleGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainThrottleGroupsThrottleGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _throttleGroups = value;
            }
        }
    }
}
