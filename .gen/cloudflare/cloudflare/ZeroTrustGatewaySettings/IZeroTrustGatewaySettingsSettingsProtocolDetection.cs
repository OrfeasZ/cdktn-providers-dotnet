using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewaySettingsSettingsProtocolDetection), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsProtocolDetection")]
    public interface IZeroTrustGatewaySettingsSettingsProtocolDetection
    {
        /// <summary>Specify whether to detect protocols from the initial bytes of client traffic.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewaySettingsSettingsProtocolDetection), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsProtocolDetection")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsProtocolDetection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify whether to detect protocols from the initial bytes of client traffic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#enabled ZeroTrustGatewaySettings#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
