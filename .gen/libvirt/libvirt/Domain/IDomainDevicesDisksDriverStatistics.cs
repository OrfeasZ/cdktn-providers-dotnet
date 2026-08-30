using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksDriverStatistics), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverStatistics")]
    public interface IDomainDevicesDisksDriverStatistics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#latency_histogram Domain#latency_histogram}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksDriverStatisticsLatencyHistogram" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "latencyHistogram", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverStatisticsLatencyHistogram\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LatencyHistogram
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#statistic Domain#statistic}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksDriverStatisticsStatistic" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "statistic", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverStatisticsStatistic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Statistic
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksDriverStatistics), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverStatistics")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksDriverStatistics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#latency_histogram Domain#latency_histogram}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksDriverStatisticsLatencyHistogram" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latencyHistogram", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverStatisticsLatencyHistogram\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LatencyHistogram
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#statistic Domain#statistic}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksDriverStatisticsStatistic" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statistic", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverStatisticsStatistic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Statistic
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
