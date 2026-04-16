using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConnectionRulesRdp")]
    public class ZeroTrustAccessPolicyConnectionRulesRdp : cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConnectionRulesRdp
    {
        /// <summary>Clipboard formats allowed when copying from local machine to remote RDP session.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#allowed_clipboard_local_to_remote_formats ZeroTrustAccessPolicy#allowed_clipboard_local_to_remote_formats}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedClipboardLocalToRemoteFormats", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedClipboardLocalToRemoteFormats
        {
            get;
            set;
        }

        /// <summary>Clipboard formats allowed when copying from remote RDP session to local machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#allowed_clipboard_remote_to_local_formats ZeroTrustAccessPolicy#allowed_clipboard_remote_to_local_formats}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedClipboardRemoteToLocalFormats", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedClipboardRemoteToLocalFormats
        {
            get;
            set;
        }
    }
}
