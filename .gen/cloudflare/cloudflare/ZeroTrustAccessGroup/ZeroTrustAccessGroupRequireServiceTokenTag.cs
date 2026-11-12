using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireServiceTokenTag")]
    public class ZeroTrustAccessGroupRequireServiceTokenTag : cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireServiceTokenTag
    {
        /// <summary>The tag key to match. Keys are case-sensitive and may contain Unicode letters and digits, underscores, periods, and hyphens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_access_group#key ZeroTrustAccessGroup#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>The tag value to match. Values are case-sensitive, preserve whitespace, and must not contain NUL characters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_access_group#value ZeroTrustAccessGroup#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
