using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsPayloadLog), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsPayloadLog")]
    public interface IZeroTrustGatewayPolicyRuleSettingsPayloadLog
    {
        /// <summary>Enable DLP payload logging for this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#enabled ZeroTrustGatewayPolicy#enabled}
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

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsPayloadLog), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsPayloadLog")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsPayloadLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enable DLP payload logging for this rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#enabled ZeroTrustGatewayPolicy#enabled}
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
