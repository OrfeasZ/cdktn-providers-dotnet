using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTuneEmulatorPin), fullyQualifiedName: "libvirt.domain.DomainCpuTuneEmulatorPin")]
    public interface IDomainCpuTuneEmulatorPin
    {
        /// <summary>Defines the cpuset of host CPUs on which the emulator thread may run, using the standard cpuset syntax such as "0-3" or "1,3,5";</summary>
        /// <remarks>
        /// this attribute is required when emulator pinning is configured.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cpu_set Domain#cpu_set}
        /// </remarks>
        [JsiiProperty(name: "cpuSet", typeJson: "{\"primitive\":\"string\"}")]
        string CpuSet
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTuneEmulatorPin), fullyQualifiedName: "libvirt.domain.DomainCpuTuneEmulatorPin")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTuneEmulatorPin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines the cpuset of host CPUs on which the emulator thread may run, using the standard cpuset syntax such as "0-3" or "1,3,5";</summary>
            /// <remarks>
            /// this attribute is required when emulator pinning is configured.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cpu_set Domain#cpu_set}
            /// </remarks>
            [JsiiProperty(name: "cpuSet", typeJson: "{\"primitive\":\"string\"}")]
            public string CpuSet
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
