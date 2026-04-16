using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyRequireGeo), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGeo")]
    public interface IZeroTrustAccessPolicyRequireGeo
    {
        /// <summary>The country code that should be matched.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#country_code ZeroTrustAccessPolicy#country_code}
        /// </remarks>
        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
        string CountryCode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyRequireGeo), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGeo")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGeo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The country code that should be matched.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#country_code ZeroTrustAccessPolicy#country_code}
            /// </remarks>
            [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
            public string CountryCode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
