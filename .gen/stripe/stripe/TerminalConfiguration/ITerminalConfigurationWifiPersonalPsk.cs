using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiInterface(nativeType: typeof(ITerminalConfigurationWifiPersonalPsk), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationWifiPersonalPsk")]
    public interface ITerminalConfigurationWifiPersonalPsk
    {
        /// <summary>Password for connecting to the WiFi network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#password TerminalConfiguration#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Name of the WiFi network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#ssid TerminalConfiguration#ssid}
        /// </remarks>
        [JsiiProperty(name: "ssid", typeJson: "{\"primitive\":\"string\"}")]
        string Ssid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITerminalConfigurationWifiPersonalPsk), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationWifiPersonalPsk")]
        internal sealed class _Proxy : DeputyBase, stripe.TerminalConfiguration.ITerminalConfigurationWifiPersonalPsk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Password for connecting to the WiFi network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#password TerminalConfiguration#password}
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the WiFi network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#ssid TerminalConfiguration#ssid}
            /// </remarks>
            [JsiiProperty(name: "ssid", typeJson: "{\"primitive\":\"string\"}")]
            public string Ssid
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
