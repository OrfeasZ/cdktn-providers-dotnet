using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally")]
    public interface IZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally
    {
        /// <summary>Specify the fallback behavior to apply when the internal DNS response code differs from 'NOERROR' or when the response data contains only CNAME records for 'A' or 'AAAA' queries.</summary>
        /// <remarks>
        /// Available values: "none", "public_dns".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#fallback ZeroTrustGatewayPolicy#fallback}
        /// </remarks>
        [JsiiProperty(name: "fallback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Fallback
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the internal DNS view identifier to pass to the internal DNS service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#view_id ZeroTrustGatewayPolicy#view_id}
        /// </remarks>
        [JsiiProperty(name: "viewId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ViewId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the fallback behavior to apply when the internal DNS response code differs from 'NOERROR' or when the response data contains only CNAME records for 'A' or 'AAAA' queries.</summary>
            /// <remarks>
            /// Available values: "none", "public_dns".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#fallback ZeroTrustGatewayPolicy#fallback}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fallback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Fallback
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the internal DNS view identifier to pass to the internal DNS service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#view_id ZeroTrustGatewayPolicy#view_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "viewId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ViewId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
