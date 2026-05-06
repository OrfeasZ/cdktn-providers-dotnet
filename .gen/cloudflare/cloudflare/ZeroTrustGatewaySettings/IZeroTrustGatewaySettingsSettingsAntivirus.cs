using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewaySettingsSettingsAntivirus), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirus")]
    public interface IZeroTrustGatewaySettingsSettingsAntivirus
    {
        /// <summary>Enable anti-virus scanning on downloads.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#enabled_download_phase ZeroTrustGatewaySettings#enabled_download_phase}
        /// </remarks>
        [JsiiProperty(name: "enabledDownloadPhase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnabledDownloadPhase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable anti-virus scanning on uploads.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#enabled_upload_phase ZeroTrustGatewaySettings#enabled_upload_phase}
        /// </remarks>
        [JsiiProperty(name: "enabledUploadPhase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnabledUploadPhase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Block requests for files that cannot be scanned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#fail_closed ZeroTrustGatewaySettings#fail_closed}
        /// </remarks>
        [JsiiProperty(name: "failClosed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailClosed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure a message to display on the user's device when an antivirus search is performed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#notification_settings ZeroTrustGatewaySettings#notification_settings}
        /// </remarks>
        [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirusNotificationSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsAntivirusNotificationSettings? NotificationSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewaySettingsSettingsAntivirus), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirus")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsAntivirus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enable anti-virus scanning on downloads.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#enabled_download_phase ZeroTrustGatewaySettings#enabled_download_phase}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabledDownloadPhase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnabledDownloadPhase
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enable anti-virus scanning on uploads.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#enabled_upload_phase ZeroTrustGatewaySettings#enabled_upload_phase}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabledUploadPhase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnabledUploadPhase
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Block requests for files that cannot be scanned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#fail_closed ZeroTrustGatewaySettings#fail_closed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failClosed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FailClosed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configure a message to display on the user's device when an antivirus search is performed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#notification_settings ZeroTrustGatewaySettings#notification_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirusNotificationSettings\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsAntivirusNotificationSettings? NotificationSettings
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsAntivirusNotificationSettings?>();
            }
        }
    }
}
