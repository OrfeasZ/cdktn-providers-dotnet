using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainClock")]
    public class DomainClock : libvirt.Domain.IDomainClock
    {
        /// <summary>Sets a numeric time adjustment applied to the guest clock on startup or reset, interpreted in seconds unless a different unit is implied by `basis`;</summary>
        /// <remarks>
        /// the value is user-provided (e.g. <c>-3600</c>).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#adjustment Domain#adjustment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adjustment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Adjustment
        {
            get;
            set;
        }

        /// <summary>Selects how `adjustment` is interpreted relative to the base time, with allowed values `utc` or `localtime`;</summary>
        /// <remarks>
        /// if omitted, libvirt uses its default behavior.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#basis Domain#basis}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "basis", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Basis
        {
            get;
            set;
        }

        /// <summary>Controls what time the guest sees at boot, with common values `utc`, `localtime`, `timezone`, or `variable` to follow or diverge from the host clock.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#offset Domain#offset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Offset
        {
            get;
            set;
        }

        /// <summary>Specifies when the clock settings take effect, with valid values such as `utc`, `localtime`, or `absolute` depending on mode;</summary>
        /// <remarks>
        /// the exact allowed values are driver-specific.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#start Domain#start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Start
        {
            get;
            set;
        }

        private object? _timer;

        /// <summary>Defines one or more hardware or paravirtualized timers for the guest clock (e.g. HPET, KVM clock), including their policies and catch-up behavior.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#timer Domain#timer}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainClockTimer" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainClockTimer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Timer
        {
            get => _timer;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainClockTimer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainClockTimer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _timer = value;
            }
        }

        /// <summary>Sets the IANA time zone name used when `offset` is `timezone`, such as `UTC`, `Europe/Berlin`, or `America/New_York`.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#time_zone Domain#time_zone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
        {
            get;
            set;
        }
    }
}
