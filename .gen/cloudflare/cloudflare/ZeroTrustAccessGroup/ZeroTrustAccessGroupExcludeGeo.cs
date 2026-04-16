using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGeo")]
    public class ZeroTrustAccessGroupExcludeGeo : cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGeo
    {
        /// <summary>The country code that should be matched.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#country_code ZeroTrustAccessGroup#country_code}
        /// </remarks>
        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
        public string CountryCode
        {
            get;
            set;
        }
    }
}
