using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainClockTimerCatchUp), fullyQualifiedName: "libvirt.domain.DomainClockTimerCatchUp")]
    public interface IDomainClockTimerCatchUp
    {
        /// <summary>Sets the maximum time difference, in seconds, that the catch-up mechanism is allowed to correct before giving up and letting the guest stay behind;</summary>
        /// <remarks>
        /// the value is a positive integer chosen by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#limit Domain#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Limit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum speed-up factor (relative to real time) used when the guest clock is catching up after being behind the host clock;</summary>
        /// <remarks>
        /// value is user-provided and typically a positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#slew Domain#slew}
        /// </remarks>
        [JsiiProperty(name: "slew", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Slew
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the time difference (in seconds) beyond which the catch-up mechanism is used instead of stepping the guest clock;</summary>
        /// <remarks>
        /// value is user-provided and usually a positive integer (e.g. 10 or 300).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#threshold Domain#threshold}
        /// </remarks>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Threshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainClockTimerCatchUp), fullyQualifiedName: "libvirt.domain.DomainClockTimerCatchUp")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainClockTimerCatchUp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the maximum time difference, in seconds, that the catch-up mechanism is allowed to correct before giving up and letting the guest stay behind;</summary>
            /// <remarks>
            /// the value is a positive integer chosen by the user.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#limit Domain#limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum speed-up factor (relative to real time) used when the guest clock is catching up after being behind the host clock;</summary>
            /// <remarks>
            /// value is user-provided and typically a positive integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#slew Domain#slew}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slew", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Slew
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the time difference (in seconds) beyond which the catch-up mechanism is used instead of stepping the guest clock;</summary>
            /// <remarks>
            /// value is user-provided and usually a positive integer (e.g. 10 or 300).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#time-keeping">https://libvirt.org/formatdomain.html#time-keeping</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#threshold Domain#threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Threshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
