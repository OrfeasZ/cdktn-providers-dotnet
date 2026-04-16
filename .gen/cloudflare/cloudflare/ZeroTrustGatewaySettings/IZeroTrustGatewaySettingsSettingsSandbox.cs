using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewaySettingsSettingsSandbox), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsSandbox")]
    public interface IZeroTrustGatewaySettingsSettingsSandbox
    {
        /// <summary>Specify whether to enable the sandbox.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#enabled ZeroTrustGatewaySettings#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the action to take when the system cannot scan the file. Available values: "allow", "block".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#fallback_action ZeroTrustGatewaySettings#fallback_action}
        /// </remarks>
        [JsiiProperty(name: "fallbackAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FallbackAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewaySettingsSettingsSandbox), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsSandbox")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsSandbox
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify whether to enable the sandbox.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#enabled ZeroTrustGatewaySettings#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specify the action to take when the system cannot scan the file. Available values: "allow", "block".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#fallback_action ZeroTrustGatewaySettings#fallback_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fallbackAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FallbackAction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
