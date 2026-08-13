using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiInterface(nativeType: typeof(ITerminalConfigurationWifiEnterpriseEapPeap), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapPeap")]
    public interface ITerminalConfigurationWifiEnterpriseEapPeap
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

        /// <summary>Username for connecting to the WiFi network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#username TerminalConfiguration#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        /// <summary>A File ID representing a PEM file containing the server certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#ca_certificate_file TerminalConfiguration#ca_certificate_file}
        /// </remarks>
        [JsiiProperty(name: "caCertificateFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaCertificateFile
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITerminalConfigurationWifiEnterpriseEapPeap), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapPeap")]
        internal sealed class _Proxy : DeputyBase, stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapPeap
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

            /// <summary>Username for connecting to the WiFi network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#username TerminalConfiguration#username}
            /// </remarks>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A File ID representing a PEM file containing the server certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#ca_certificate_file TerminalConfiguration#ca_certificate_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "caCertificateFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaCertificateFile
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
