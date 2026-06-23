using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainClockTimer), fullyQualifiedName: "libvirt.domain.DomainClockTimer")]
    public interface IDomainClockTimer
    {
        /// <summary>Selects which hardware or virtual timer this entry configures (for example "rtc", "pit", "hpet", "tsc", "kvmclock");</summary>
        /// <remarks>
        /// value must be a timer name supported by the guest architecture and hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Configures how a timer behaves when the guest falls behind real time, enabling or tuning the “catchup” mechanism instead of an immediate jump.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#catch_up Domain#catch_up}
        /// </remarks>
        [JsiiProperty(name: "catchUp", typeJson: "{\"fqn\":\"libvirt.domain.DomainClockTimerCatchUp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainClockTimerCatchUp? CatchUp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the frequency of the given timer device in Hertz;</summary>
        /// <remarks>
        /// value is user-provided and must be a positive integer (for example 100 or 1000) when overriding the default.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#frequency Domain#frequency}
        /// </remarks>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Frequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets how the timer operates, with typical values including "auto", "native", or "emulate" depending on the timer type;</summary>
        /// <remarks>
        /// value must be one of the modes supported by the chosen hypervisor/timer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the specified timer is exposed to the guest, using "yes" to enable or "no" to omit it.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#present Domain#present}
        /// </remarks>
        [JsiiProperty(name: "present", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Present
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets how missed timer ticks are handled, with valid values including "delay", "catchup", and "merge";</summary>
        /// <remarks>
        /// for example "delay" shifts subsequent ticks, while "catchup" speeds the clock up briefly.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tick_policy Domain#tick_policy}
        /// </remarks>
        [JsiiProperty(name: "tickPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TickPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls how the guest timer tracks the host, typically using values such as "boot", "guest", or "wall" depending on the specific timer;</summary>
        /// <remarks>
        /// value must be one of the tracking modes supported by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#track Domain#track}
        /// </remarks>
        [JsiiProperty(name: "track", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Track
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainClockTimer), fullyQualifiedName: "libvirt.domain.DomainClockTimer")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainClockTimer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Selects which hardware or virtual timer this entry configures (for example "rtc", "pit", "hpet", "tsc", "kvmclock");</summary>
            /// <remarks>
            /// value must be a timer name supported by the guest architecture and hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configures how a timer behaves when the guest falls behind real time, enabling or tuning the “catchup” mechanism instead of an immediate jump.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#catch_up Domain#catch_up}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "catchUp", typeJson: "{\"fqn\":\"libvirt.domain.DomainClockTimerCatchUp\"}", isOptional: true)]
            public libvirt.Domain.IDomainClockTimerCatchUp? CatchUp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainClockTimerCatchUp?>();
            }

            /// <summary>Sets the frequency of the given timer device in Hertz;</summary>
            /// <remarks>
            /// value is user-provided and must be a positive integer (for example 100 or 1000) when overriding the default.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#frequency Domain#frequency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Frequency
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets how the timer operates, with typical values including "auto", "native", or "emulate" depending on the timer type;</summary>
            /// <remarks>
            /// value must be one of the modes supported by the chosen hypervisor/timer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the specified timer is exposed to the guest, using "yes" to enable or "no" to omit it.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#present Domain#present}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "present", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Present
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets how missed timer ticks are handled, with valid values including "delay", "catchup", and "merge";</summary>
            /// <remarks>
            /// for example "delay" shifts subsequent ticks, while "catchup" speeds the clock up briefly.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tick_policy Domain#tick_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tickPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TickPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls how the guest timer tracks the host, typically using values such as "boot", "guest", or "wall" depending on the specific timer;</summary>
            /// <remarks>
            /// value must be one of the tracking modes supported by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#track Domain#track}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "track", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Track
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
