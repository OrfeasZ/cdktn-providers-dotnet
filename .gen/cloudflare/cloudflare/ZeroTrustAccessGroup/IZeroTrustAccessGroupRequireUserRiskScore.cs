using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessGroupRequireUserRiskScore), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireUserRiskScore")]
    public interface IZeroTrustAccessGroupRequireUserRiskScore
    {
        /// <summary>A list of risk score levels to match. Values can be low, medium, high, or unscored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#user_risk_score ZeroTrustAccessGroup#user_risk_score}
        /// </remarks>
        [JsiiProperty(name: "userRiskScore", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] UserRiskScore
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessGroupRequireUserRiskScore), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireUserRiskScore")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireUserRiskScore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of risk score levels to match. Values can be low, medium, high, or unscored.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#user_risk_score ZeroTrustAccessGroup#user_risk_score}
            /// </remarks>
            [JsiiProperty(name: "userRiskScore", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] UserRiskScore
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
