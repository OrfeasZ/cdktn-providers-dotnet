using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTuneIoThreadSched), fullyQualifiedName: "libvirt.domain.DomainCpuTuneIoThreadSched")]
    public interface IDomainCpuTuneIoThreadSched
    {
        /// <summary>Specifies the IOThread or set of IOThreads to which this scheduling configuration applies, usually as a comma-separated list of IOThread IDs (for example, "1" or "1,2");</summary>
        /// <remarks>
        /// this attribute is required.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_threads Domain#io_threads}
        /// </remarks>
        [JsiiProperty(name: "ioThreads", typeJson: "{\"primitive\":\"string\"}")]
        string IoThreads
        {
            get;
        }

        /// <summary>Sets the scheduler priority for the selected IOThreads;</summary>
        /// <remarks>
        /// valid numeric range depends on the chosen scheduler policy and host kernel, and is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#priority Domain#priority}
        /// </remarks>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the scheduler policy for IOThreads, using one of the supported cgroup scheduler values such as `batch`, `fifo`, `rr`, or `both`;</summary>
        /// <remarks>
        /// if omitted, the hypervisor’s default scheduling policy is used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#scheduler Domain#scheduler}
        /// </remarks>
        [JsiiProperty(name: "scheduler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scheduler
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTuneIoThreadSched), fullyQualifiedName: "libvirt.domain.DomainCpuTuneIoThreadSched")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTuneIoThreadSched
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the IOThread or set of IOThreads to which this scheduling configuration applies, usually as a comma-separated list of IOThread IDs (for example, "1" or "1,2");</summary>
            /// <remarks>
            /// this attribute is required.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_threads Domain#io_threads}
            /// </remarks>
            [JsiiProperty(name: "ioThreads", typeJson: "{\"primitive\":\"string\"}")]
            public string IoThreads
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the scheduler priority for the selected IOThreads;</summary>
            /// <remarks>
            /// valid numeric range depends on the chosen scheduler policy and host kernel, and is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#priority Domain#priority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the scheduler policy for IOThreads, using one of the supported cgroup scheduler values such as `batch`, `fifo`, `rr`, or `both`;</summary>
            /// <remarks>
            /// if omitted, the hypervisor’s default scheduling policy is used.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#scheduler Domain#scheduler}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scheduler
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
