using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsUntrustedCert), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsUntrustedCert")]
    public interface IZeroTrustGatewayPolicyRuleSettingsUntrustedCert
    {
        /// <summary>Defines the action performed when an untrusted certificate seen.</summary>
        /// <remarks>
        /// The default action an error with HTTP code 526.
        /// Available values: "pass_through", "block", "error".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#action ZeroTrustGatewayPolicy#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsUntrustedCert), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsUntrustedCert")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsUntrustedCert
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines the action performed when an untrusted certificate seen.</summary>
            /// <remarks>
            /// The default action an error with HTTP code 526.
            /// Available values: "pass_through", "block", "error".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#action ZeroTrustGatewayPolicy#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
