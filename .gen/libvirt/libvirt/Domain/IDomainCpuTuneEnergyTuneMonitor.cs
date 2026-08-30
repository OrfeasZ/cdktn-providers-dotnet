using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTuneEnergyTuneMonitor), fullyQualifiedName: "libvirt.domain.DomainCpuTuneEnergyTuneMonitor")]
    public interface IDomainCpuTuneEnergyTuneMonitor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpus Domain#vcpus}.</summary>
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}")]
        string Vcpus
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTuneEnergyTuneMonitor), fullyQualifiedName: "libvirt.domain.DomainCpuTuneEnergyTuneMonitor")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTuneEnergyTuneMonitor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpus Domain#vcpus}.</summary>
            [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}")]
            public string Vcpus
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
