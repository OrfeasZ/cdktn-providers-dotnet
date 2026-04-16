using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesIncludeCommonName), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCommonName")]
    public interface IZeroTrustAccessApplicationPoliciesIncludeCommonName
    {
        /// <summary>The common name to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#common_name ZeroTrustAccessApplication#common_name}
        /// </remarks>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        string CommonName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesIncludeCommonName), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCommonName")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCommonName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The common name to match.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#common_name ZeroTrustAccessApplication#common_name}
            /// </remarks>
            [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
            public string CommonName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
