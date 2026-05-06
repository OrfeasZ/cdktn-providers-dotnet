using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettings")]
    public class ZeroTrustGatewaySettingsSettings : cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettings
    {
        /// <summary>Activity log settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#activity_log ZeroTrustGatewaySettings#activity_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activityLog", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsActivityLog\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsActivityLog? ActivityLog
        {
            get;
            set;
        }

        /// <summary>Anti-virus settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#antivirus ZeroTrustGatewaySettings#antivirus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "antivirus", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirus\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsAntivirus? Antivirus
        {
            get;
            set;
        }

        /// <summary>Block page layout settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#block_page ZeroTrustGatewaySettings#block_page}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockPage", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPage\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage? BlockPage
        {
            get;
            set;
        }

        /// <summary>DLP body scanning settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#body_scanning ZeroTrustGatewaySettings#body_scanning}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bodyScanning", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBodyScanning\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBodyScanning? BodyScanning
        {
            get;
            set;
        }

        /// <summary>Browser isolation settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#browser_isolation ZeroTrustGatewaySettings#browser_isolation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "browserIsolation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBrowserIsolation\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBrowserIsolation? BrowserIsolation
        {
            get;
            set;
        }

        /// <summary>Certificate settings for Gateway TLS interception. If not specified, the Cloudflare Root CA will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#certificate ZeroTrustGatewaySettings#certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCertificate\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCertificate? Certificate
        {
            get;
            set;
        }

        /// <summary>Custom certificate settings for BYO-PKI. (deprecated and replaced by `certificate`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#custom_certificate ZeroTrustGatewaySettings#custom_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customCertificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCustomCertificate\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCustomCertificate? CustomCertificate
        {
            get;
            set;
        }

        /// <summary>Extended e-mail matching settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#extended_email_matching ZeroTrustGatewaySettings#extended_email_matching}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extendedEmailMatching", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsExtendedEmailMatching\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsExtendedEmailMatching? ExtendedEmailMatching
        {
            get;
            set;
        }

        /// <summary>FIPS settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#fips ZeroTrustGatewaySettings#fips}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fips", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsFips\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsFips? Fips
        {
            get;
            set;
        }

        /// <summary>Setting to enable host selector in egress policies.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#host_selector ZeroTrustGatewaySettings#host_selector}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostSelector", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsHostSelector\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsHostSelector? HostSelector
        {
            get;
            set;
        }

        /// <summary>Protocol Detection settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#protocol_detection ZeroTrustGatewaySettings#protocol_detection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocolDetection", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsProtocolDetection\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsProtocolDetection? ProtocolDetection
        {
            get;
            set;
        }

        /// <summary>Sandbox settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#sandbox ZeroTrustGatewaySettings#sandbox}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sandbox", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsSandbox\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsSandbox? Sandbox
        {
            get;
            set;
        }

        /// <summary>TLS interception settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#tls_decrypt ZeroTrustGatewaySettings#tls_decrypt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tlsDecrypt", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsTlsDecrypt\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsTlsDecrypt? TlsDecrypt
        {
            get;
            set;
        }
    }
}
