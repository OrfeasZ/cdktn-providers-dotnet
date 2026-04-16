using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthMethod")]
    public class ZeroTrustAccessApplicationPoliciesRequireAuthMethod : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAuthMethod
    {
        /// <summary>The type of authentication method https://datatracker.ietf.org/doc/html/rfc8176#section-2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#auth_method ZeroTrustAccessApplication#auth_method}
        /// </remarks>
        [JsiiProperty(name: "authMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthMethod
        {
            get;
            set;
        }
    }
}
