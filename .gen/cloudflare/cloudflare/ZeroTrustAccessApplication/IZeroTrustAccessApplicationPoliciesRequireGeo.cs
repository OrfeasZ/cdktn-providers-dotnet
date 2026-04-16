using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesRequireGeo), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGeo")]
    public interface IZeroTrustAccessApplicationPoliciesRequireGeo
    {
        /// <summary>The country code that should be matched.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#country_code ZeroTrustAccessApplication#country_code}
        /// </remarks>
        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
        string CountryCode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesRequireGeo), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGeo")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGeo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The country code that should be matched.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#country_code ZeroTrustAccessApplication#country_code}
            /// </remarks>
            [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
            public string CountryCode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
