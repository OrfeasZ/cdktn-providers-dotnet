using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyConnectionRules), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConnectionRules")]
    public interface IZeroTrustAccessPolicyConnectionRules
    {
        /// <summary>The RDP-specific rules that define clipboard behavior for RDP connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#rdp ZeroTrustAccessPolicy#rdp}
        /// </remarks>
        [JsiiProperty(name: "rdp", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConnectionRulesRdp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConnectionRulesRdp? Rdp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyConnectionRules), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConnectionRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConnectionRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The RDP-specific rules that define clipboard behavior for RDP connections.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#rdp ZeroTrustAccessPolicy#rdp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rdp", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConnectionRulesRdp\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConnectionRulesRdp? Rdp
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConnectionRulesRdp?>();
            }
        }
    }
}
