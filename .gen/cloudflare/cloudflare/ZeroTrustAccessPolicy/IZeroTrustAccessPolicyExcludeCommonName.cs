using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyExcludeCommonName), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeCommonName")]
    public interface IZeroTrustAccessPolicyExcludeCommonName
    {
        /// <summary>The common name to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#common_name ZeroTrustAccessPolicy#common_name}
        /// </remarks>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        string CommonName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyExcludeCommonName), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeCommonName")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeCommonName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The common name to match.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#common_name ZeroTrustAccessPolicy#common_name}
            /// </remarks>
            [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
            public string CommonName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
