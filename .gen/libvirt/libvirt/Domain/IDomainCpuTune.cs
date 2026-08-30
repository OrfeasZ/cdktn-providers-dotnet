using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTune), fullyQualifiedName: "libvirt.domain.DomainCpuTune")]
    public interface IDomainCpuTune
    {
        /// <summary>Configures cache allocation and partitioning between NUMA cells or vCPUs, allowing you to reserve or limit portions of shared caches.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cache_tune Domain#cache_tune}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneCacheTune" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "cacheTune", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneCacheTune\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CacheTune
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the CPU time period in microseconds used to calculate cgroup quota for the QEMU emulator thread;</summary>
        /// <remarks>
        /// value is a positive integer and is user-provided (for example, 100000).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator_period Domain#emulator_period}
        /// </remarks>
        [JsiiProperty(name: "emulatorPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EmulatorPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures CPU pinning for the QEMU emulator thread, constraining it to a specific set of host CPUs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator_pin Domain#emulator_pin}
        /// </remarks>
        [JsiiProperty(name: "emulatorPin", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneEmulatorPin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainCpuTuneEmulatorPin? EmulatorPin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the total CPU time in microseconds that the emulator thread is allowed to consume per scheduling period;</summary>
        /// <remarks>
        /// value is a user-provided integer, typically positive to enforce a limit or -1 for unlimited where supported.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator_quota Domain#emulator_quota}
        /// </remarks>
        [JsiiProperty(name: "emulatorQuota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EmulatorQuota
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the scheduler policy and priority for the emulator thread within its cgroup.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator_sched Domain#emulator_sched}
        /// </remarks>
        [JsiiProperty(name: "emulatorSched", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneEmulatorSched\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainCpuTuneEmulatorSched? EmulatorSched
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#energy_tune Domain#energy_tune}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneEnergyTune" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "energyTune", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneEnergyTune\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnergyTune
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the global CPU period in microseconds used as the base for quota calculations for all vCPUs and emulator threads unless overridden;</summary>
        /// <remarks>
        /// value is a positive integer and user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#global_period Domain#global_period}
        /// </remarks>
        [JsiiProperty(name: "globalPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GlobalPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the global CPU time quota in microseconds per period for the entire domain, limiting aggregate CPU usage across all vCPUs and emulator threads;</summary>
        /// <remarks>
        /// value is a user-provided integer, commonly positive or -1 for unlimited where supported.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#global_quota Domain#global_quota}
        /// </remarks>
        [JsiiProperty(name: "globalQuota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GlobalQuota
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the CPU time period in microseconds used to calculate cgroup quota for IOThreads;</summary>
        /// <remarks>
        /// value is a positive, user-provided integer (for example, 100000).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread_period Domain#io_thread_period}
        /// </remarks>
        [JsiiProperty(name: "ioThreadPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IoThreadPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures CPU pinning for a specific IOThread, constraining that IOThread to a set of host CPUs.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread_pin Domain#io_thread_pin}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneIoThreadPin" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ioThreadPin", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneIoThreadPin\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IoThreadPin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the total CPU time in microseconds that each IOThread is allowed to consume per scheduling period when per-IOThread quotas are enabled;</summary>
        /// <remarks>
        /// value is a user-provided integer, typically positive or -1 for unlimited where supported.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread_quota Domain#io_thread_quota}
        /// </remarks>
        [JsiiProperty(name: "ioThreadQuota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IoThreadQuota
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures scheduler policy and priority for one or more IOThreads.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread_sched Domain#io_thread_sched}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneIoThreadSched" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ioThreadSched", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneIoThreadSched\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IoThreadSched
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables per-vCPU memory bandwidth tuning for the domain, grouping configuration for monitored vCPUs and per-NUMA-node memory bandwidth caps.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_tune Domain#memory_tune}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneMemoryTune" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "memoryTune", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTune\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MemoryTune
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the CPU cgroup scheduler period in microseconds for all vCPUs, controlling the time window used with `quota` (for example, `100000`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#period Domain#period}
        /// </remarks>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Period
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the total CPU time in microseconds allowed per `period` for all vCPUs, using a positive integer or `-1` for no limit.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#quota Domain#quota}
        /// </remarks>
        [JsiiProperty(name: "quota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Quota
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the relative CPU weight (shares) of the domain in the CPU cgroup, typically a positive integer such as `1024` used for proportional scheduling.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#shares Domain#shares}
        /// </remarks>
        [JsiiProperty(name: "shares", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Shares
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more pinning rules mapping each virtual CPU to a specific set of host CPUs for execution.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpu_pin Domain#vcpu_pin}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneVcpuPin" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "vcpuPin", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneVcpuPin\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VcpuPin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures scheduler attributes for one or more groups of vCPUs, such as scheduler class and priority.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpu_sched Domain#vcpu_sched}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneVcpuSched" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "vcpuSched", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneVcpuSched\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VcpuSched
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTune), fullyQualifiedName: "libvirt.domain.DomainCpuTune")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTune
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures cache allocation and partitioning between NUMA cells or vCPUs, allowing you to reserve or limit portions of shared caches.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cache_tune Domain#cache_tune}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneCacheTune" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheTune", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneCacheTune\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CacheTune
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the CPU time period in microseconds used to calculate cgroup quota for the QEMU emulator thread;</summary>
            /// <remarks>
            /// value is a positive integer and is user-provided (for example, 100000).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator_period Domain#emulator_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emulatorPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EmulatorPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures CPU pinning for the QEMU emulator thread, constraining it to a specific set of host CPUs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator_pin Domain#emulator_pin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emulatorPin", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneEmulatorPin\"}", isOptional: true)]
            public libvirt.Domain.IDomainCpuTuneEmulatorPin? EmulatorPin
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainCpuTuneEmulatorPin?>();
            }

            /// <summary>Sets the total CPU time in microseconds that the emulator thread is allowed to consume per scheduling period;</summary>
            /// <remarks>
            /// value is a user-provided integer, typically positive to enforce a limit or -1 for unlimited where supported.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator_quota Domain#emulator_quota}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emulatorQuota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EmulatorQuota
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures the scheduler policy and priority for the emulator thread within its cgroup.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator_sched Domain#emulator_sched}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emulatorSched", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneEmulatorSched\"}", isOptional: true)]
            public libvirt.Domain.IDomainCpuTuneEmulatorSched? EmulatorSched
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainCpuTuneEmulatorSched?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#energy_tune Domain#energy_tune}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneEnergyTune" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "energyTune", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneEnergyTune\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EnergyTune
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the global CPU period in microseconds used as the base for quota calculations for all vCPUs and emulator threads unless overridden;</summary>
            /// <remarks>
            /// value is a positive integer and user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#global_period Domain#global_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "globalPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GlobalPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the global CPU time quota in microseconds per period for the entire domain, limiting aggregate CPU usage across all vCPUs and emulator threads;</summary>
            /// <remarks>
            /// value is a user-provided integer, commonly positive or -1 for unlimited where supported.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#global_quota Domain#global_quota}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "globalQuota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GlobalQuota
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the CPU time period in microseconds used to calculate cgroup quota for IOThreads;</summary>
            /// <remarks>
            /// value is a positive, user-provided integer (for example, 100000).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread_period Domain#io_thread_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThreadPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IoThreadPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures CPU pinning for a specific IOThread, constraining that IOThread to a set of host CPUs.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread_pin Domain#io_thread_pin}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneIoThreadPin" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThreadPin", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneIoThreadPin\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IoThreadPin
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the total CPU time in microseconds that each IOThread is allowed to consume per scheduling period when per-IOThread quotas are enabled;</summary>
            /// <remarks>
            /// value is a user-provided integer, typically positive or -1 for unlimited where supported.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread_quota Domain#io_thread_quota}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThreadQuota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IoThreadQuota
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures scheduler policy and priority for one or more IOThreads.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread_sched Domain#io_thread_sched}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneIoThreadSched" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThreadSched", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneIoThreadSched\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IoThreadSched
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enables per-vCPU memory bandwidth tuning for the domain, grouping configuration for monitored vCPUs and per-NUMA-node memory bandwidth caps.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_tune Domain#memory_tune}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneMemoryTune" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryTune", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTune\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MemoryTune
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the CPU cgroup scheduler period in microseconds for all vCPUs, controlling the time window used with `quota` (for example, `100000`).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#period Domain#period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Period
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the total CPU time in microseconds allowed per `period` for all vCPUs, using a positive integer or `-1` for no limit.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#quota Domain#quota}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Quota
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the relative CPU weight (shares) of the domain in the CPU cgroup, typically a positive integer such as `1024` used for proportional scheduling.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#shares Domain#shares}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shares", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Shares
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures one or more pinning rules mapping each virtual CPU to a specific set of host CPUs for execution.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpu_pin Domain#vcpu_pin}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneVcpuPin" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpuPin", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneVcpuPin\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VcpuPin
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures scheduler attributes for one or more groups of vCPUs, such as scheduler class and priority.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpu_sched Domain#vcpu_sched}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneVcpuSched" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpuSched", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneVcpuSched\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VcpuSched
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
