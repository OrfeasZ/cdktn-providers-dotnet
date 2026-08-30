using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksDriverStatistics")]
    public class DomainDevicesDisksDriverStatistics : libvirt.Domain.IDomainDevicesDisksDriverStatistics
    {
        private object? _latencyHistogram;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#latency_histogram Domain#latency_histogram}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksDriverStatisticsLatencyHistogram" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "latencyHistogram", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverStatisticsLatencyHistogram\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LatencyHistogram
        {
            get => _latencyHistogram;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesDisksDriverStatisticsLatencyHistogram[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksDriverStatisticsLatencyHistogram).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _latencyHistogram = value;
            }
        }

        private object? _statistic;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#statistic Domain#statistic}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksDriverStatisticsStatistic" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statistic", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverStatisticsStatistic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Statistic
        {
            get => _statistic;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesDisksDriverStatisticsStatistic[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksDriverStatisticsStatistic).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _statistic = value;
            }
        }
    }
}
