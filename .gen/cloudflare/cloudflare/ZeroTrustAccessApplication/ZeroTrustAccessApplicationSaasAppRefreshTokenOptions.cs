using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptions")]
    public class ZeroTrustAccessApplicationSaasAppRefreshTokenOptions : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppRefreshTokenOptions
    {
        /// <summary>How long a refresh token will be valid for after creation.</summary>
        /// <remarks>
        /// Valid units are m,h,d. Must be longer than 1m.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#lifetime ZeroTrustAccessApplication#lifetime}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Lifetime
        {
            get;
            set;
        }
    }
}
