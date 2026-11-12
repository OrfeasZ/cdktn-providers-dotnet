using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCwsPolicySet
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCwsPolicySetPolicies), fullyQualifiedName: "cloudflare.zeroTrustCwsPolicySet.ZeroTrustCwsPolicySetPolicies")]
    public interface IZeroTrustCwsPolicySetPolicies
    {
        /// <summary>ID of the member policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_policy_set#policy_id ZeroTrustCwsPolicySet#policy_id}
        /// </remarks>
        [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyId
        {
            get;
        }

        /// <summary>Whether this policy should enforce when it matches. Defaults to true; false keeps the policy attached for non-enforcing evaluation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_policy_set#enforce ZeroTrustCwsPolicySet#enforce}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enforce", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enforce
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCwsPolicySetPolicies), fullyQualifiedName: "cloudflare.zeroTrustCwsPolicySet.ZeroTrustCwsPolicySetPolicies")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCwsPolicySet.IZeroTrustCwsPolicySetPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the member policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_policy_set#policy_id ZeroTrustCwsPolicySet#policy_id}
            /// </remarks>
            [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether this policy should enforce when it matches. Defaults to true; false keeps the policy attached for non-enforcing evaluation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_policy_set#enforce ZeroTrustCwsPolicySet#enforce}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enforce", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enforce
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
