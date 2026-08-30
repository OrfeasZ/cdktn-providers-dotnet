using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTuneMemoryTuneMonitor), fullyQualifiedName: "libvirt.domain.DomainCpuTuneMemoryTuneMonitor")]
    public interface IDomainCpuTuneMemoryTuneMonitor
    {
        /// <summary>Sets the monitoring level for memory bandwidth (for example, a cache or memory hierarchy level), as a user-provided string understood by the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#level Domain#level}
        /// </remarks>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Level
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the set of vCPUs to monitor for memory bandwidth, using the libvirt CPU set syntax (e.g. `0-3`, `0,2,4`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpus Domain#vcpus}
        /// </remarks>
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Vcpus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTuneMemoryTuneMonitor), fullyQualifiedName: "libvirt.domain.DomainCpuTuneMemoryTuneMonitor")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTuneMemoryTuneMonitor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the monitoring level for memory bandwidth (for example, a cache or memory hierarchy level), as a user-provided string understood by the hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#level Domain#level}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Level
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specifies the set of vCPUs to monitor for memory bandwidth, using the libvirt CPU set syntax (e.g. `0-3`, `0,2,4`).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpus Domain#vcpus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Vcpus
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
