using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksDriverStatisticsStatistic), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverStatisticsStatistic")]
    public interface IDomainDevicesDisksDriverStatisticsStatistic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#interval Domain#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        double Interval
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksDriverStatisticsStatistic), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverStatisticsStatistic")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksDriverStatisticsStatistic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#interval Domain#interval}.</summary>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
            public double Interval
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
