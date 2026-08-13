using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.terminalConfiguration.TerminalConfigurationWifi")]
    public class TerminalConfigurationWifi : stripe.TerminalConfiguration.ITerminalConfigurationWifi
    {
        /// <summary>Security type of the WiFi network. The hash with the corresponding name contains the credentials for this security type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#type TerminalConfiguration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#enterprise_eap_peap TerminalConfiguration#enterprise_eap_peap}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enterpriseEapPeap", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapPeap\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapPeap? EnterpriseEapPeap
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#enterprise_eap_tls TerminalConfiguration#enterprise_eap_tls}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enterpriseEapTls", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapTls\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapTls? EnterpriseEapTls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#personal_psk TerminalConfiguration#personal_psk}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "personalPsk", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiPersonalPsk\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationWifiPersonalPsk? PersonalPsk
        {
            get;
            set;
        }
    }
}
