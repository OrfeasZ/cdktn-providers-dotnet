using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiInterface(nativeType: typeof(ITerminalConfigurationWifiEnterpriseEapTls), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapTls")]
    public interface ITerminalConfigurationWifiEnterpriseEapTls
    {
        /// <summary>A File ID representing a PEM file containing the client certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#client_certificate_file TerminalConfiguration#client_certificate_file}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateFile", typeJson: "{\"primitive\":\"string\"}")]
        string ClientCertificateFile
        {
            get;
        }

        /// <summary>A File ID representing a PEM file containing the client RSA private key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#private_key_file TerminalConfiguration#private_key_file}
        /// </remarks>
        [JsiiProperty(name: "privateKeyFile", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateKeyFile
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

        /// <summary>Password for the private key file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#private_key_file_password TerminalConfiguration#private_key_file_password}
        /// </remarks>
        [JsiiProperty(name: "privateKeyFilePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateKeyFilePassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITerminalConfigurationWifiEnterpriseEapTls), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapTls")]
        internal sealed class _Proxy : DeputyBase, stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A File ID representing a PEM file containing the client certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#client_certificate_file TerminalConfiguration#client_certificate_file}
            /// </remarks>
            [JsiiProperty(name: "clientCertificateFile", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientCertificateFile
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A File ID representing a PEM file containing the client RSA private key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#private_key_file TerminalConfiguration#private_key_file}
            /// </remarks>
            [JsiiProperty(name: "privateKeyFile", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateKeyFile
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

            /// <summary>Password for the private key file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#private_key_file_password TerminalConfiguration#private_key_file_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateKeyFilePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateKeyFilePassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
