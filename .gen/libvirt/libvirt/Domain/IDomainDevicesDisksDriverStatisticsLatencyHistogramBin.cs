using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksDriverStatisticsLatencyHistogramBin), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverStatisticsLatencyHistogramBin")]
    public interface IDomainDevicesDisksDriverStatisticsLatencyHistogramBin
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#start Domain#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        double Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksDriverStatisticsLatencyHistogramBin), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverStatisticsLatencyHistogramBin")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksDriverStatisticsLatencyHistogramBin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#start Domain#start}.</summary>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
            public double Start
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
