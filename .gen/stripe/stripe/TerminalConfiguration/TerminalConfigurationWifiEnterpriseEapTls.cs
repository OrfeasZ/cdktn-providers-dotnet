using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapTls")]
    public class TerminalConfigurationWifiEnterpriseEapTls : stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapTls
    {
        /// <summary>A File ID representing a PEM file containing the client certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#client_certificate_file TerminalConfiguration#client_certificate_file}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateFile", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientCertificateFile
        {
            get;
            set;
        }

        /// <summary>A File ID representing a PEM file containing the client RSA private key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#private_key_file TerminalConfiguration#private_key_file}
        /// </remarks>
        [JsiiProperty(name: "privateKeyFile", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateKeyFile
        {
            get;
            set;
        }

        /// <summary>Name of the WiFi network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#ssid TerminalConfiguration#ssid}
        /// </remarks>
        [JsiiProperty(name: "ssid", typeJson: "{\"primitive\":\"string\"}")]
        public string Ssid
        {
            get;
            set;
        }

        /// <summary>A File ID representing a PEM file containing the server certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#ca_certificate_file TerminalConfiguration#ca_certificate_file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "caCertificateFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaCertificateFile
        {
            get;
            set;
        }

        /// <summary>Password for the private key file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#private_key_file_password TerminalConfiguration#private_key_file_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateKeyFilePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKeyFilePassword
        {
            get;
            set;
        }
    }
}
