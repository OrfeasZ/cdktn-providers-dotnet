using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiInterface(nativeType: typeof(ITerminalConfigurationRebootWindow), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationRebootWindow")]
    public interface ITerminalConfigurationRebootWindow
    {
        /// <summary>Integer between 0 to 23 that represents the end hour of the reboot time window.</summary>
        /// <remarks>
        /// The value must be different than the start_hour.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#end_hour TerminalConfiguration#end_hour}
        /// </remarks>
        [JsiiProperty(name: "endHour", typeJson: "{\"primitive\":\"number\"}")]
        double EndHour
        {
            get;
        }

        /// <summary>Integer between 0 to 23 that represents the start hour of the reboot time window.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#start_hour TerminalConfiguration#start_hour}
        /// </remarks>
        [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}")]
        double StartHour
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITerminalConfigurationRebootWindow), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationRebootWindow")]
        internal sealed class _Proxy : DeputyBase, stripe.TerminalConfiguration.ITerminalConfigurationRebootWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Integer between 0 to 23 that represents the end hour of the reboot time window.</summary>
            /// <remarks>
            /// The value must be different than the start_hour.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#end_hour TerminalConfiguration#end_hour}
            /// </remarks>
            [JsiiProperty(name: "endHour", typeJson: "{\"primitive\":\"number\"}")]
            public double EndHour
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Integer between 0 to 23 that represents the start hour of the reboot time window.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#start_hour TerminalConfiguration#start_hour}
            /// </remarks>
            [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}")]
            public double StartHour
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
