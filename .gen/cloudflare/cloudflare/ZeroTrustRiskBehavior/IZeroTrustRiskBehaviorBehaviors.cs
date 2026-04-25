using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustRiskBehavior
{
    [JsiiInterface(nativeType: typeof(IZeroTrustRiskBehaviorBehaviors), fullyQualifiedName: "cloudflare.zeroTrustRiskBehavior.ZeroTrustRiskBehaviorBehaviors")]
    public interface IZeroTrustRiskBehaviorBehaviors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_risk_behavior#enabled ZeroTrustRiskBehavior#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Available values: "low", "medium", "high".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_risk_behavior#risk_level ZeroTrustRiskBehavior#risk_level}
        /// </remarks>
        [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}")]
        string RiskLevel
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustRiskBehaviorBehaviors), fullyQualifiedName: "cloudflare.zeroTrustRiskBehavior.ZeroTrustRiskBehaviorBehaviors")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustRiskBehavior.IZeroTrustRiskBehaviorBehaviors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_risk_behavior#enabled ZeroTrustRiskBehavior#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Available values: "low", "medium", "high".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_risk_behavior#risk_level ZeroTrustRiskBehavior#risk_level}
            /// </remarks>
            [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string RiskLevel
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
