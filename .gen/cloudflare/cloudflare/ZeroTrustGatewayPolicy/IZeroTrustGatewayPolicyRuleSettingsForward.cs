using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsForward), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsForward")]
    public interface IZeroTrustGatewayPolicyRuleSettingsForward
    {
        /// <summary>Specify the public Worker ID of the target Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_gateway_policy#worker_id ZeroTrustGatewayPolicy#worker_id}
        /// </remarks>
        [JsiiProperty(name: "workerId", typeJson: "{\"primitive\":\"string\"}")]
        string WorkerId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsForward), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsForward")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the public Worker ID of the target Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_gateway_policy#worker_id ZeroTrustGatewayPolicy#worker_id}
            /// </remarks>
            [JsiiProperty(name: "workerId", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkerId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
