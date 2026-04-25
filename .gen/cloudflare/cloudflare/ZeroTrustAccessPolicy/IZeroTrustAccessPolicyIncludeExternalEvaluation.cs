using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyIncludeExternalEvaluation), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeExternalEvaluation")]
    public interface IZeroTrustAccessPolicyIncludeExternalEvaluation
    {
        /// <summary>The API endpoint containing your business logic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#evaluate_url ZeroTrustAccessPolicy#evaluate_url}
        /// </remarks>
        [JsiiProperty(name: "evaluateUrl", typeJson: "{\"primitive\":\"string\"}")]
        string EvaluateUrl
        {
            get;
        }

        /// <summary>The API endpoint containing the key that Access uses to verify that the response came from your API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#keys_url ZeroTrustAccessPolicy#keys_url}
        /// </remarks>
        [JsiiProperty(name: "keysUrl", typeJson: "{\"primitive\":\"string\"}")]
        string KeysUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyIncludeExternalEvaluation), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeExternalEvaluation")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeExternalEvaluation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The API endpoint containing your business logic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#evaluate_url ZeroTrustAccessPolicy#evaluate_url}
            /// </remarks>
            [JsiiProperty(name: "evaluateUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string EvaluateUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The API endpoint containing the key that Access uses to verify that the response came from your API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#keys_url ZeroTrustAccessPolicy#keys_url}
            /// </remarks>
            [JsiiProperty(name: "keysUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string KeysUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
