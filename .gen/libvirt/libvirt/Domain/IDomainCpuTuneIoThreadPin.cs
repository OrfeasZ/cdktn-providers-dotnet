using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTuneIoThreadPin), fullyQualifiedName: "libvirt.domain.DomainCpuTuneIoThreadPin")]
    public interface IDomainCpuTuneIoThreadPin
    {
        /// <summary>Defines the cpuset of host CPUs on which the specified IOThread may run, using cpuset syntax like "0,2-3";</summary>
        /// <remarks>
        /// this attribute is required for each io_thread_pin entry.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cpu_set Domain#cpu_set}
        /// </remarks>
        [JsiiProperty(name: "cpuSet", typeJson: "{\"primitive\":\"string\"}")]
        string CpuSet
        {
            get;
        }

        /// <summary>Identifies which IOThread is being pinned by index, using the IOThread ID as defined in the domain (for example, 1 or 2);</summary>
        /// <remarks>
        /// this attribute is required for each io_thread_pin entry.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_thread Domain#io_thread}
        /// </remarks>
        [JsiiProperty(name: "ioThread", typeJson: "{\"primitive\":\"number\"}")]
        double IoThread
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTuneIoThreadPin), fullyQualifiedName: "libvirt.domain.DomainCpuTuneIoThreadPin")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTuneIoThreadPin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines the cpuset of host CPUs on which the specified IOThread may run, using cpuset syntax like "0,2-3";</summary>
            /// <remarks>
            /// this attribute is required for each io_thread_pin entry.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cpu_set Domain#cpu_set}
            /// </remarks>
            [JsiiProperty(name: "cpuSet", typeJson: "{\"primitive\":\"string\"}")]
            public string CpuSet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifies which IOThread is being pinned by index, using the IOThread ID as defined in the domain (for example, 1 or 2);</summary>
            /// <remarks>
            /// this attribute is required for each io_thread_pin entry.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_thread Domain#io_thread}
            /// </remarks>
            [JsiiProperty(name: "ioThread", typeJson: "{\"primitive\":\"number\"}")]
            public double IoThread
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
