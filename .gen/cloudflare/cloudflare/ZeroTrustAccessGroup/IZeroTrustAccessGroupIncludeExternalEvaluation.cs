using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessGroupIncludeExternalEvaluation), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeExternalEvaluation")]
    public interface IZeroTrustAccessGroupIncludeExternalEvaluation
    {
        /// <summary>The API endpoint containing your business logic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#evaluate_url ZeroTrustAccessGroup#evaluate_url}
        /// </remarks>
        [JsiiProperty(name: "evaluateUrl", typeJson: "{\"primitive\":\"string\"}")]
        string EvaluateUrl
        {
            get;
        }

        /// <summary>The API endpoint containing the key that Access uses to verify that the response came from your API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#keys_url ZeroTrustAccessGroup#keys_url}
        /// </remarks>
        [JsiiProperty(name: "keysUrl", typeJson: "{\"primitive\":\"string\"}")]
        string KeysUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessGroupIncludeExternalEvaluation), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeExternalEvaluation")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeExternalEvaluation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The API endpoint containing your business logic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#evaluate_url ZeroTrustAccessGroup#evaluate_url}
            /// </remarks>
            [JsiiProperty(name: "evaluateUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string EvaluateUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The API endpoint containing the key that Access uses to verify that the response came from your API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#keys_url ZeroTrustAccessGroup#keys_url}
            /// </remarks>
            [JsiiProperty(name: "keysUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string KeysUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
