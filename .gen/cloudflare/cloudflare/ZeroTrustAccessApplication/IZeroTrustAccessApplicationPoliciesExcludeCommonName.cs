using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesExcludeCommonName), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCommonName")]
    public interface IZeroTrustAccessApplicationPoliciesExcludeCommonName
    {
        /// <summary>The common name to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#common_name ZeroTrustAccessApplication#common_name}
        /// </remarks>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        string CommonName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesExcludeCommonName), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCommonName")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeCommonName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The common name to match.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#common_name ZeroTrustAccessApplication#common_name}
            /// </remarks>
            [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
            public string CommonName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
