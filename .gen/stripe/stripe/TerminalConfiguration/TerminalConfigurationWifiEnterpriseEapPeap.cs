using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapPeap")]
    public class TerminalConfigurationWifiEnterpriseEapPeap : stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapPeap
    {
        /// <summary>Password for connecting to the WiFi network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#password TerminalConfiguration#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
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

        /// <summary>Username for connecting to the WiFi network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#username TerminalConfiguration#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
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
    }
}
