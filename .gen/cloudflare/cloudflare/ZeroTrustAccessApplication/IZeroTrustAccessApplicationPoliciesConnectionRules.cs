using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesConnectionRules), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRules")]
    public interface IZeroTrustAccessApplicationPoliciesConnectionRules
    {
        /// <summary>The SSH-specific rules that define how users may connect to the targets secured by your application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_access_application#ssh ZeroTrustAccessApplication#ssh}
        /// </remarks>
        [JsiiProperty(name: "ssh", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRulesSsh\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesConnectionRulesSsh? Ssh
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesConnectionRules), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesConnectionRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The SSH-specific rules that define how users may connect to the targets secured by your application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_access_application#ssh ZeroTrustAccessApplication#ssh}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssh", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRulesSsh\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesConnectionRulesSsh? Ssh
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesConnectionRulesSsh?>();
            }
        }
    }
}
