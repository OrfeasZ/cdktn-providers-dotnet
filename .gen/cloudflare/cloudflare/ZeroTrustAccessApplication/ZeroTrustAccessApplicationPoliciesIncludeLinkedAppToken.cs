using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken")]
    public class ZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken
    {
        /// <summary>The ID of an Access OIDC SaaS application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#app_uid ZeroTrustAccessApplication#app_uid}
        /// </remarks>
        [JsiiProperty(name: "appUid", typeJson: "{\"primitive\":\"string\"}")]
        public string AppUid
        {
            get;
            set;
        }
    }
}
