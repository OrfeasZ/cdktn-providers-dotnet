using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesExcludeGeo), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGeo")]
    public interface IZeroTrustAccessApplicationPoliciesExcludeGeo
    {
        /// <summary>The country code that should be matched.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#country_code ZeroTrustAccessApplication#country_code}
        /// </remarks>
        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
        string CountryCode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesExcludeGeo), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGeo")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeGeo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The country code that should be matched.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#country_code ZeroTrustAccessApplication#country_code}
            /// </remarks>
            [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
            public string CountryCode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
