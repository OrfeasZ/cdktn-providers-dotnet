using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewaySettingsSettings), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettings")]
    public interface IZeroTrustGatewaySettingsSettings
    {
        /// <summary>Activity log settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#activity_log ZeroTrustGatewaySettings#activity_log}
        /// </remarks>
        [JsiiProperty(name: "activityLog", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsActivityLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsActivityLog? ActivityLog
        {
            get
            {
                return null;
            }
        }

        /// <summary>Anti-virus settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#antivirus ZeroTrustGatewaySettings#antivirus}
        /// </remarks>
        [JsiiProperty(name: "antivirus", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirus\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsAntivirus? Antivirus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Block page layout settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#block_page ZeroTrustGatewaySettings#block_page}
        /// </remarks>
        [JsiiProperty(name: "blockPage", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage? BlockPage
        {
            get
            {
                return null;
            }
        }

        /// <summary>DLP body scanning settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#body_scanning ZeroTrustGatewaySettings#body_scanning}
        /// </remarks>
        [JsiiProperty(name: "bodyScanning", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBodyScanning\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBodyScanning? BodyScanning
        {
            get
            {
                return null;
            }
        }

        /// <summary>Browser isolation settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#browser_isolation ZeroTrustGatewaySettings#browser_isolation}
        /// </remarks>
        [JsiiProperty(name: "browserIsolation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBrowserIsolation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBrowserIsolation? BrowserIsolation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Certificate settings for Gateway TLS interception. If not specified, the Cloudflare Root CA will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#certificate ZeroTrustGatewaySettings#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCertificate? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Custom certificate settings for BYO-PKI. (deprecated and replaced by `certificate`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#custom_certificate ZeroTrustGatewaySettings#custom_certificate}
        /// </remarks>
        [JsiiProperty(name: "customCertificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCustomCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCustomCertificate? CustomCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Extended e-mail matching settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#extended_email_matching ZeroTrustGatewaySettings#extended_email_matching}
        /// </remarks>
        [JsiiProperty(name: "extendedEmailMatching", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsExtendedEmailMatching\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsExtendedEmailMatching? ExtendedEmailMatching
        {
            get
            {
                return null;
            }
        }

        /// <summary>FIPS settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#fips ZeroTrustGatewaySettings#fips}
        /// </remarks>
        [JsiiProperty(name: "fips", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsFips\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsFips? Fips
        {
            get
            {
                return null;
            }
        }

        /// <summary>Setting to enable host selector in egress policies.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#host_selector ZeroTrustGatewaySettings#host_selector}
        /// </remarks>
        [JsiiProperty(name: "hostSelector", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsHostSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsHostSelector? HostSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Protocol Detection settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#protocol_detection ZeroTrustGatewaySettings#protocol_detection}
        /// </remarks>
        [JsiiProperty(name: "protocolDetection", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsProtocolDetection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsProtocolDetection? ProtocolDetection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sandbox settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#sandbox ZeroTrustGatewaySettings#sandbox}
        /// </remarks>
        [JsiiProperty(name: "sandbox", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsSandbox\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsSandbox? Sandbox
        {
            get
            {
                return null;
            }
        }

        /// <summary>TLS interception settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#tls_decrypt ZeroTrustGatewaySettings#tls_decrypt}
        /// </remarks>
        [JsiiProperty(name: "tlsDecrypt", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsTlsDecrypt\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsTlsDecrypt? TlsDecrypt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewaySettingsSettings), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Activity log settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#activity_log ZeroTrustGatewaySettings#activity_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activityLog", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsActivityLog\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsActivityLog? ActivityLog
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsActivityLog?>();
            }

            /// <summary>Anti-virus settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#antivirus ZeroTrustGatewaySettings#antivirus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "antivirus", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirus\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsAntivirus? Antivirus
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsAntivirus?>();
            }

            /// <summary>Block page layout settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#block_page ZeroTrustGatewaySettings#block_page}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockPage", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPage\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage? BlockPage
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage?>();
            }

            /// <summary>DLP body scanning settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#body_scanning ZeroTrustGatewaySettings#body_scanning}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bodyScanning", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBodyScanning\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBodyScanning? BodyScanning
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBodyScanning?>();
            }

            /// <summary>Browser isolation settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#browser_isolation ZeroTrustGatewaySettings#browser_isolation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "browserIsolation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBrowserIsolation\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBrowserIsolation? BrowserIsolation
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBrowserIsolation?>();
            }

            /// <summary>Certificate settings for Gateway TLS interception. If not specified, the Cloudflare Root CA will be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#certificate ZeroTrustGatewaySettings#certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCertificate\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCertificate? Certificate
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCertificate?>();
            }

            /// <summary>Custom certificate settings for BYO-PKI. (deprecated and replaced by `certificate`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#custom_certificate ZeroTrustGatewaySettings#custom_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customCertificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCustomCertificate\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCustomCertificate? CustomCertificate
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCustomCertificate?>();
            }

            /// <summary>Extended e-mail matching settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#extended_email_matching ZeroTrustGatewaySettings#extended_email_matching}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extendedEmailMatching", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsExtendedEmailMatching\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsExtendedEmailMatching? ExtendedEmailMatching
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsExtendedEmailMatching?>();
            }

            /// <summary>FIPS settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#fips ZeroTrustGatewaySettings#fips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fips", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsFips\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsFips? Fips
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsFips?>();
            }

            /// <summary>Setting to enable host selector in egress policies.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#host_selector ZeroTrustGatewaySettings#host_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostSelector", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsHostSelector\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsHostSelector? HostSelector
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsHostSelector?>();
            }

            /// <summary>Protocol Detection settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#protocol_detection ZeroTrustGatewaySettings#protocol_detection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocolDetection", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsProtocolDetection\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsProtocolDetection? ProtocolDetection
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsProtocolDetection?>();
            }

            /// <summary>Sandbox settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#sandbox ZeroTrustGatewaySettings#sandbox}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sandbox", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsSandbox\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsSandbox? Sandbox
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsSandbox?>();
            }

            /// <summary>TLS interception settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#tls_decrypt ZeroTrustGatewaySettings#tls_decrypt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlsDecrypt", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsTlsDecrypt\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsTlsDecrypt? TlsDecrypt
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsTlsDecrypt?>();
            }
        }
    }
}
