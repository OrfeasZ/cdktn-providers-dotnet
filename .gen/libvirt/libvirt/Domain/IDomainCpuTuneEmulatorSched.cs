using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTuneEmulatorSched), fullyQualifiedName: "libvirt.domain.DomainCpuTuneEmulatorSched")]
    public interface IDomainCpuTuneEmulatorSched
    {
        /// <summary>Sets the scheduler priority for the emulator thread;</summary>
        /// <remarks>
        /// the valid numeric range depends on the chosen scheduler policy and host kernel (value is user-provided).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#priority Domain#priority}
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

        /// <summary>Selects the scheduler policy for the emulator thread, typically one of "batch", "fifo", "rr", or "idle" where supported;</summary>
        /// <remarks>
        /// value is user-provided and must match a kernel scheduling class.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#scheduler Domain#scheduler}
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

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTuneEmulatorSched), fullyQualifiedName: "libvirt.domain.DomainCpuTuneEmulatorSched")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTuneEmulatorSched
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the scheduler priority for the emulator thread;</summary>
            /// <remarks>
            /// the valid numeric range depends on the chosen scheduler policy and host kernel (value is user-provided).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#priority Domain#priority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Selects the scheduler policy for the emulator thread, typically one of "batch", "fifo", "rr", or "idle" where supported;</summary>
            /// <remarks>
            /// value is user-provided and must match a kernel scheduling class.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#scheduler Domain#scheduler}
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
