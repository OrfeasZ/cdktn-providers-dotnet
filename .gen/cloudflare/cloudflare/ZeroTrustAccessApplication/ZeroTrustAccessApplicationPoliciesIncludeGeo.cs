using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGeo")]
    public class ZeroTrustAccessApplicationPoliciesIncludeGeo : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGeo
    {
        /// <summary>The country code that should be matched.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#country_code ZeroTrustAccessApplication#country_code}
        /// </remarks>
        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
        public string CountryCode
        {
            get;
            set;
        }
    }
}
