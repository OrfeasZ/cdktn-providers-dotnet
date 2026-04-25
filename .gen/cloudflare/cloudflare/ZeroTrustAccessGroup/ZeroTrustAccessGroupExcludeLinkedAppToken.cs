using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLinkedAppToken")]
    public class ZeroTrustAccessGroupExcludeLinkedAppToken : cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLinkedAppToken
    {
        /// <summary>The ID of an Access OIDC SaaS application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#app_uid ZeroTrustAccessGroup#app_uid}
        /// </remarks>
        [JsiiProperty(name: "appUid", typeJson: "{\"primitive\":\"string\"}")]
        public string AppUid
        {
            get;
            set;
        }
    }
}
